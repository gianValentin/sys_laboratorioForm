using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sys_Laboratorio
{
    static class Program
    {
        public static string cnn;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(conexion())
                Application.Run(new frmIngreso());
            else
            {
                MessageBox.Show("Error en la Conexion con la Base de Datos\nVerifique que la Base de Datos Este Instalada Correctamente\nERROR_CLASE_PROGRAM<Main> ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }            
        }
        private static bool  conexion()
        {
            bool ok = false;
            try
            {
                MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
                sb.Server = "localhost";
                sb.Database = "db_laboratorio";
                sb.UserID = "root";
                sb.Password = "48836498@";
                cnn = sb.ConnectionString;
                MySqlConnection cn = new MySqlConnection(cnn);
                cn.Open();
                ok = true;
                cn.Close();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            return ok;
        }
        public static string obtenerDato(string query)
        {
            string dato = "";
            try
            {
                MySqlConnection cn = new MySqlConnection(Program.cnn);
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    dato = dr[0].ToString();
                }
                else
                {
                    dato = "Dato No Encotrado";
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                dato = "ERROR DE SISTEMA";
                MessageBox.Show(ex.ToString());
            }
            return dato;
        }
    }
}
