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
    public partial class frmRespaldoBasedatos : Form
    {
        public frmRespaldoBasedatos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAtencion frm = new frmAtencion();
            frm.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();

            guardar.InitialDirectory = @"C:\Users\gian\Documents\";
            guardar.Title = "Guardar Examen";
            guardar.DefaultExt = "sql";
            guardar.Filter = "Archivo sql (*.sql)|*.sql";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                backup_mysql(guardar.FileName);
            }
        }
        private void backup_mysql(string ruta)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Program.cnn))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(ruta);
                            conn.Close();
                            MessageBox.Show("Exito!! Respaldo realizado\nRuta:" + ruta, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}
