using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Sys_Laboratorio
{
    public partial class frmNuevaAtencion : Form
    {
        private int tipoPaciente = 1;
        private int TipoAtencion = 1;
        public frmNuevaAtencion()
        {
            InitializeComponent();
        }

        private void frmNuevaAtencion_Load(object sender, EventArgs e)
        {
            lblCodigoAtencion.Text = obtenerCodigo("SELECT IdAtenciones FROM Atenciones order by IdAtenciones desc Limit 1;",1);
            txtIdPaciente.Text = obtenerCodigo("SELECT IdPaciente FROM Pacientes order by IdPaciente desc Limit 1;", 2);
            cargarGridPacientes("SELECT * FROM Pacientes");
            cargarListaExamenes();
            ptbImagen.Image = Image.FromFile(Application.StartupPath+@"\Imagenes\Inicio.png");
            Screen pantalla = Screen.PrimaryScreen;
            if (pantalla.Bounds.Height < 920)
            {
                this.Height = pantalla.Bounds.Height - 60;
                this.CenterToScreen();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreExamen = "";
            if (cbxTipoExamen.SelectedIndex > -1)
                nombreExamen = cbxTipoExamen.SelectedItem.ToString();
            cargarEstructuraExamen("select * from TipoExamen WHERE Nombre='" + nombreExamen+"'");
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            tipoPaciente = 1;
            btnNuevoPaciente.Enabled = false;
            txtIdPaciente.Text = obtenerCodigo("SELECT IdPaciente FROM Pacientes order by IdPaciente desc Limit 1;", 2);
            txtNombres.Clear();
            txtApellidos.Clear();
            cbxGenero.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now.Date;
        }

        private void lstPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoPaciente = 2;
            btnNuevoPaciente.Enabled = true;
            int pos = lstPacientes.FocusedItem.Index;
            txtIdPaciente.Text = lstPacientes.Items[pos].SubItems[0].Text;
            txtNombres.Text = lstPacientes.Items[pos].SubItems[1].Text;
            txtApellidos.Text = lstPacientes.Items[pos].SubItems[2].Text;
            cbxGenero.SelectedItem = lstPacientes.Items[pos].SubItems[3].Text;
            dtpFechaNacimiento.Value = Convert.ToDateTime(lstPacientes.Items[pos].SubItems[4].Text);
        }
        private void txtBusquedaNombre_TextChanged(object sender, EventArgs e)
        {
            cargarGridPacientes("SELECT * FROM Pacientes WHERE Nombres like '"+txtBusquedaNombre.Text+"%';");
        }

        private void txtBusquedaApellido_TextChanged(object sender, EventArgs e)
        {
            cargarGridPacientes("SELECT * FROM Pacientes WHERE Apellidos like '" + txtBusquedaApellido.Text + "%';");
        }

        private void btnGuargarDatos_Click(object sender, EventArgs e)
        {
            if (verificaDatosCompletados())
            {                
                CRUD();
                if(DialogResult.Yes==MessageBox.Show("Desea Agregar Otro Examen a esta Atencion", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    tipoPaciente = 2;
                    TipoAtencion = 2;
                    cbxTipoExamen.SelectedIndex = -1;
                    gbxPacientesRegistrados.Enabled = false;
                    gbxDatosPaciente.Enabled = false;
                }
                else
                {
                    tipoPaciente = 1;
                    TipoAtencion = 1;
                    restaurarDatos();
                }
            }
            else
                MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        //
        //FUNCIONES Y PROCEDIMIENTOS:
        //
        private void cargarGridPacientes(string query)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(Program.cnn);
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                lstPacientes.Items.Clear();
                if (dr.HasRows)
                {                    
                    while (dr.Read())
                    {
                        string[] dato = new string[5];
                        for (int i = 0; i < dato.Length; i++)
                            dato[i] = dr[i].ToString();
                        dato[4] = Convert.ToDateTime(dato[4]).ToShortDateString();
                        ListViewItem fila = new ListViewItem(dato);
                        lstPacientes.Items.Add(fila);
                    }
                }         
                cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private string obtenerCodigo(string query,int tabla)
        {
            string cod = "";
            MySqlConnection cnn = new MySqlConnection(Program.cnn);
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            try
            {
                cnn.Open();
                cod = (string)(cmd.ExecuteScalar());
                if (tabla == 1)
                {
                    if (String.IsNullOrEmpty(cod))
                        cod = "A0001";
                    else
                        cod = "A" + (Convert.ToInt32(cod.Substring(1, 4)) + 1).ToString("0000");                    
                }else if (tabla == 2)
                {
                    if (String.IsNullOrEmpty(cod))
                        cod = "P0001";
                    else
                        cod = "P" + (Convert.ToInt32(cod.Substring(1, 4)) + 1).ToString("0000");
                }
                else if (tabla == 3)
                {
                    if (String.IsNullOrEmpty(cod))
                        cod = "E0001";
                    else
                        cod = "E" + (Convert.ToInt32(cod.Substring(1, 4)) + 1).ToString("0000");
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return cod;
        }
        private void cargarListaExamenes()
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(Program.cnn);
                MySqlCommand cmd = new MySqlCommand("SELECT Nombre FROM TipoExamen", cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbxTipoExamen.Items.Add(dr[0].ToString());
                }
                cn.Close();
            }catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void cargarEstructuraExamen(string query)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(Program.cnn);
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    pnlControl.Controls.Clear();
                    dr.Read();
                    lblExamen.Text = dr[1].ToString();
                    
                    string[] dato = dr[3].ToString().Split('\t');
                    for (int i = 0; i < dato.Length; i++)
                    {
                        Label lbl = new Label();
                        lbl.Text = dato[i];
                        lbl.Width = 200;

                        TextBox txt = new TextBox();
                        txt.Name = "txt" + dato[i];
                        txt.Width = 200;

                        lbl.Location = new Point(10, pnlControl.Controls.Count * 15);
                        txt.Location = new Point(250, pnlControl.Controls.Count * 15);
                        pnlControl.Controls.Add(lbl);
                        pnlControl.Controls.Add(txt);
                    }
                    string imagen = Application.StartupPath + @"\Imagenes\" + dr[2].ToString();
                    if (File.Exists(imagen))
                        ptbImagen.Image = Image.FromFile(imagen);
                    else
                        ptbImagen.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\Inicio.png");
                }
                else
                {
                    pnlControl.Controls.Clear();
                    lblExamen.Text = "lblExamen";
                    ptbImagen.Image = Image.FromFile(Application.StartupPath + @"\Imagenes\Inicio.png");
                }
                    
                cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            if (!txtApellidos.Text.Equals("") && tipoPaciente==1)
            {
                if (verificarPaciente(txtNombres.Text, txtApellidos.Text.Trim()))
                    MessageBox.Show("Los datos de este pacietne ya Existe!!\nSeleccionelo en Pacientes Registrados para evitar no Duplicar Paciente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            if (!txtNombres.Text.Equals("") && tipoPaciente==1)
            {
                if(verificarPaciente(txtNombres.Text.Trim(), txtApellidos.Text))
                    MessageBox.Show("Los datos de este pacietne ya Existe!!\nSeleccionelo en Pacientes Registrados para evitar no Duplicar Paciente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool verificaDatosCompletados()
        {
            bool ok = false;
            if(!txtIdPaciente.Text.Equals("") && !txtNombres.Text.Equals("") && !txtApellidos.Text.Equals("") && cbxGenero.SelectedIndex>-1)
            {
                if (cbxTipoExamen.SelectedIndex > -1 )
                    ok = true;
            }
            return ok;
        }
        private void CRUD()
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(Program.cnn);
                MySqlCommand cmd = new MySqlCommand("spu_atencion", cn);
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IdPaciente", txtIdPaciente.Text.Trim());
                cmd.Parameters.AddWithValue("NombresP", txtNombres.Text.Trim());
                cmd.Parameters.AddWithValue("ApellidosP", txtApellidos.Text.Trim());
                cmd.Parameters.AddWithValue("GeneroP", cbxGenero.SelectedItem);//
                cmd.Parameters.AddWithValue("F_NaciminetoP", dtpFechaNacimiento.Value);

                cmd.Parameters.AddWithValue("IdAtenciones", lblCodigoAtencion.Text.Trim());
                cmd.Parameters.AddWithValue("F_AtencionA", Convert.ToDateTime(dtpFechaExamen.Value));
                cmd.Parameters.AddWithValue("H_AtencionA", DateTime.Now.TimeOfDay);//

                cmd.Parameters.AddWithValue("IdExamenes", obtenerCodigo("SELECT IdExamenes FROM Examenes order by IdExamenes desc Limit 1;", 3));
                cmd.Parameters.AddWithValue("IdTipoExamenE", Program.obtenerDato("SELECT IdTipoExamen From TipoExamen Where Nombre='" + cbxTipoExamen.SelectedItem + "';"));
                cmd.Parameters.AddWithValue("Dato1E", datosExamen());
                cmd.Parameters.AddWithValue("F_Examen", Convert.ToDateTime(dtpFechaExamen.Value));

                cmd.Parameters.AddWithValue("TipoPaciente", tipoPaciente);
                cmd.Parameters.AddWithValue("TipoAtencion", TipoAtencion);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Exito!! Datos Guardados", "Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void restaurarDatos()
        {
            lblCodigoAtencion.Text = obtenerCodigo("SELECT IdAtenciones FROM Atenciones order by IdAtenciones desc Limit 1;", 1);
            txtIdPaciente.Text = obtenerCodigo("SELECT IdPaciente FROM Pacientes order by IdPaciente desc Limit 1;", 2);
            txtNombres.Clear();
            txtApellidos.Clear();
            cbxGenero.SelectedIndex = -1;
            dtpFechaNacimiento.Value = DateTime.Now.Date;
            btnNuevoPaciente.Enabled = false;
            txtBusquedaNombre.Clear();
            txtBusquedaApellido.Clear();
            cargarGridPacientes("SELECT * FROM Pacientes");
            cbxTipoExamen.SelectedIndex = -1;
            dtpFechaExamen.Value = DateTime.Now.Date;
            gbxDatosPaciente.Enabled = true;
            gbxPacientesRegistrados.Enabled = true;
        }

        private string datosExamen()
        {
            string datos = "";
            int cont = 0;
            foreach (Control txt in pnlControl.Controls)
            {               
                if (txt is TextBox)
                {
                    if (cont != 0)
                        datos += "\t";
                    datos += txt.Text;
                    cont++;
                }                
            }
            return datos;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAtencion frm = new frmAtencion();
            frm.Visible = true;
        }

        private bool verificarPaciente(string nombre,string apellido)
        {
            bool ok = false;
            try
            {
                MySqlConnection cn = new MySqlConnection(Program.cnn);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Pacientes WHERE Nombres like '"+nombre+"' and Apellidos like '"+apellido+"';", cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    ok = true;                
                cn.Close();
            }catch(Exception ex) { MessageBox.Show(ex.ToString()); }
            return ok;
        }
    }
}
