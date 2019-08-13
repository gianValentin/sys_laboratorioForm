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
using System.Diagnostics;

namespace Sys_Laboratorio
{
    public partial class frmExamenes : Form
    {
        private string IdPaciente = frmAtencion.IdAtencion;
        public frmExamenes()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAtencion frm = new frmAtencion();
            frm.Visible = true;
        }

        private void frmExamenes_Load(object sender, EventArgs e)
        {            
            cargarDatos("SELECT P.IdPaciente, concat_ws(' ', P.Nombres, P.Apellidos) as 'nombre',P.Genero,P.F_Nacimineto,A.F_Atencion FROM Atenciones A inner Join Pacientes P on A.IdPaciente=P.IdPaciente where A.IdAtenciones='" + IdPaciente + "';", 1);
            cargarDatos("SELECT E.IdExamenes,T.Nombre,E.F_Examen FROM Examenes E Inner Join TipoExamen T on E.IdTipoExamen=T.IdTipoExamen Inner Join Atenciones A on E.IdAtenciones=A.IdAtenciones where A.IdAtenciones='" + IdPaciente + "';",2);
        }

        private void cargarDatos(string query,int tipo)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(Program.cnn);
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if(tipo==2)
                        lstExamenes.Items.Clear();
                    while (dr.Read())
                    {
                        if (tipo == 1)
                        {
                            lblIdPacietne.Text = dr[0].ToString();
                            lblNombrePaciente.Text = dr[1].ToString();
                            lblGenero.Text = dr[2].ToString();
                            lblFNacimiento.Text = Convert.ToDateTime(dr[3].ToString()).ToShortDateString();
                            lblFAtencion.Text = Convert.ToDateTime(dr[4].ToString()).ToShortDateString();
                        }
                        else if (tipo == 2)
                        {
                            string[] dato = new string[3];
                            for (int i = 0; i < dato.Length; i++)
                                dato[i] = dr[i].ToString();
                            dato[2] = Convert.ToDateTime(dato[2]).ToShortDateString();
                            ListViewItem fila = new ListViewItem(dato);
                            lstExamenes.Items.Add(fila);
                        }                        
                    }
                }
                else
                    MessageBox.Show("No Se Encontraron Examenes en Esta Atencion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void abrirExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstExamenes.Items.Count > 0)
            {
                string idExamen = lstExamenes.Items[lstExamenes.FocusedItem.Index].SubItems[0].Text;
                string examen= lstExamenes.Items[lstExamenes.FocusedItem.Index].SubItems[1].Text;
                if (Directory.Exists(Application.StartupPath + @"\Plantillas" ))
                {
                    string plantilla = Application.StartupPath + @"\Plantillas\" + examen + ".docx";
                    if (File.Exists(plantilla))
                    {
                        SaveFileDialog guardar = new SaveFileDialog();

                        guardar.InitialDirectory = @"C:\Users\gian\Desktop\";
                        guardar.Title = "Guardar Examen";
                        guardar.DefaultExt = "docx";
                        guardar.Filter = "Archivo Word (*.docx)|*.docx";

                        if (guardar.ShowDialog() == DialogResult.OK)
                        {
                            LlenarWord.CreateWordDocument(plantilla, guardar.FileName, idExamen);
                            Process.Start(guardar.FileName);
                        }
                    }
                    else
                        MessageBox.Show("No se encontro la Plantilla para este examen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("No se encontro la carpeta de plantillas\nSi la carpeta fue eliminada, no se generara ningun examen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

    }
}
