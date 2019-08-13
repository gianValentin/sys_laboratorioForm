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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            gbxNuevo.Visible = false;
            this.Height = 270;
            iniGrid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAtencion frm = new frmAtencion();
            frm.Visible = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gbxNuevo.Visible = true;
            this.Height = 350;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int pos = lstUsuarios.SelectedIndices[0];
            if (pos > -1)
            {
                if (DialogResult.Yes == MessageBox.Show("¿Seguro que deasea Eliminar Usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Hand))
                {
                    try
                    {
                        MySqlConnection cn = new MySqlConnection(Program.cnn);
                        MySqlCommand cmd = new MySqlCommand("spu_Usuarios", cn);
                        cn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("Id", lstUsuarios.Items[pos].SubItems[0].Text);
                        cmd.Parameters.AddWithValue("Usuario", "asd");
                        cmd.Parameters.AddWithValue("Contraseña", "asd");
                        cmd.Parameters.AddWithValue("Tipo", 2);
                        cmd.ExecuteNonQuery();
                        iniGrid();
                        cn.Close();
                        btnEliminar.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                    btnEliminar.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!txtUsuario.Text.Equals("") && !txtContraseña.Text.Equals(""))
            {
                gbxNuevo.Visible = false;
                this.Height = 270;
                btnNuevo.Enabled = true;
                try
                {
                    MySqlConnection cn = new MySqlConnection(Program.cnn);
                    MySqlCommand cmd = new MySqlCommand("spu_Usuarios", cn);
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Id", 1);
                    cmd.Parameters.AddWithValue("Usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("Contraseña", txtContraseña.Text);
                    cmd.Parameters.AddWithValue("Tipo", 1);
                    cmd.ExecuteNonQuery();
                    iniGrid();
                    cn.Close();
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Ingrese Datos Para Guardar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxNuevo.Visible = false;
            this.Height = 270;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void lstUsuarios_Click(object sender, EventArgs e)
        {
            int pos = lstUsuarios.SelectedIndices[0];
            if (pos > -1)
                btnEliminar.Enabled = true;
            else
                btnEliminar.Enabled = false;
        }
        private void iniGrid()
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(Program.cnn);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Usuario", cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                lstUsuarios.Items.Clear();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (!dr[1].ToString().Equals("admin"))
                        {
                            string[] dato = new string[3];
                            for (int i = 0; i < dato.Length; i++)
                                dato[i] = dr[i].ToString();
                            ListViewItem fila = new ListViewItem(dato);
                            lstUsuarios.Items.Add(fila);
                        }
                    }
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
