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
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngrsar_Click(object sender, EventArgs e)
        {            
            if (!txtUsuario.Text.Equals("") && !txtContraseña.Text.Equals(""))
            {
                if (Verifica(txtUsuario.Text, txtContraseña.Text))
                {
                    this.Visible = false;
                    frmAtencion frm = new frmAtencion();
                    frm.Show();
                }
                else
                    MessageBox.Show("Error!!\nUsuario o Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
                MessageBox.Show("Ingrese Usuario Y Contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private bool Verifica(string user, string pass)
        {
            bool verifica = false;
            try
            {
                MySqlConnection cn = new MySqlConnection(Program.cnn);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Usuario Where Usuario='" + user + "' and Contraseña=md5('" + pass + "');", cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    verifica = true;
                else
                    verifica = false;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return verifica;
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                btnIngrsar_Click(null,null);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                btnIngrsar_Click(null, null);
        }
    }
}
