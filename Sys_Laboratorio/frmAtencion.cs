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

namespace Sys_Laboratorio
{
    public partial class frmAtencion : Form
    {
        public static string IdAtencion;
        public frmAtencion()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmAtencion_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }
        private void cargarCombo()
        {
            string[] meses = { "Enero", "Febrerro", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Nobiembre", "Diciembre" };
            for (int i = 0; i < meses.Length; i++)
                cbxMes.Items.Add(meses[i]);
            int AñoAct = Convert.ToInt32(DateTime.Now.Year.ToString());
            for (int año = 2009; año <= AñoAct; año++)
                cbxAño.Items.Add(año.ToString());
            cbxAño.Text = DateTime.Now.Year.ToString();
            cbxMes.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals("") || !txtApellido.Text.Equals(""))
                filtro();
        }

        private void cbxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMes.SelectedIndex > -1)
                filtro();
        }

        private void cbxAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAño.SelectedIndex > -1)
                filtro();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cbxAño.Text = DateTime.Now.Year.ToString();
            cbxMes.SelectedIndex = DateTime.Now.Month - 1;
            filtro();
        }
        private void filtro()
        {
            string query = "SELECT A.IdAtenciones,P.Nombres,P.Apellidos,A.F_Atencion FROM Atenciones A inner join Pacientes P on A.IdPaciente=P.IdPaciente WHERE"; 
            string mes, año, nombre, apellido;
            if (!txtNombre.Text.Equals(""))
            {
                nombre = txtNombre.Text.Trim();
                query += " P.Nombres LIKE '" + nombre + "%'";
                if (!cbxAño.Text.Equals("") || !cbxMes.Text.Equals("") || !txtApellido.Text.Equals(""))
                    query += " AND";
            }
            if (!txtApellido.Text.Equals(""))
            {
                apellido = txtApellido.Text.Trim();
                query += " P.Apellidos LIKE '" + apellido + "%'";
                if (!cbxAño.Text.Equals("") || !cbxMes.Text.Equals(""))
                    query += " AND";
            }
            if (!cbxAño.Text.Equals(""))
            {
                año = cbxAño.Text;
                query += " YEAR(A.F_Atencion)=" + año;
                if (!cbxMes.Text.Equals(""))
                    query += " AND";
            }
            if (!cbxMes.Text.Equals(""))
            {
                mes = (cbxMes.SelectedIndex + 1).ToString();
                query += " MONTH(A.F_Atencion)=" + mes;
            }
            query += " order by A.F_Atencion desc,A.H_Atencion desc";
            lstPacientes.Items.Clear();
            try
            {
                MySqlConnection cn = new MySqlConnection(Program.cnn);
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string[] fila = new string[4];
                    for (int i = 0; i < fila.Length; i++)
                    {
                        fila[i] = dr[i].ToString();
                    }
                    fila[3] = DateTime.Parse(fila[3]).ToShortDateString();
                    ListViewItem item = new ListViewItem(fila);
                    lstPacientes.Items.Add(item);

                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void examenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstPacientes.Items.Count > 0)
            {
                IdAtencion = lstPacientes.Items[lstPacientes.FocusedItem.Index].SubItems[0].Text;
                frmExamenes frm = new frmExamenes();
                frm.Show();
                this.Visible = false;
            }            
        }

        private void nuevoExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevaAtencion frm = new frmNuevaAtencion();
            frm.Show();
            this.Visible = false;
        }

        private void frmAtencion_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                txtNombre.Clear();
                txtApellido.Clear();
                cbxAño.Text = DateTime.Now.Year.ToString();
                cbxMes.SelectedIndex = DateTime.Now.Month - 1;
                filtro();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();
            frm.Show();
            this.Visible = false;
        }

        private void respaldoDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRespaldoBasedatos frm = new frmRespaldoBasedatos();
            frm.Show();
            this.Visible = false;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAcercaDe frm = new frmAcercaDe();
            //frm.Show();
            //this.Visible = false;
        }
    }
}
