using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Sys_Laboratorio
{
    class LlenarWord
    {
        private static string nombre = "";
        private static string fecha = "";
        private static string dato1 = "";
        private static string dato2 = "";
        private static void cargarDatosExamen(string idExamen)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(Program.cnn);
                MySqlCommand cmd = new MySqlCommand("SELECT concat_ws(' ', P.Nombres, P.Apellidos),E.F_Examen,T.Datos,E.Dato1 FROM Examenes E inner join TipoExamen T on E.IdTipoExamen=T.IdTipoExamen inner join Atenciones A on E.IdAtenciones=A.IdAtenciones inner join Pacientes P on A.IdPaciente=P.IdPaciente Where E.IdExamenes='" + idExamen + "';", cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nombre = dr[0].ToString().ToUpper();
                    fecha = Convert.ToDateTime(dr[1].ToString()).ToString("dd - MM - yyyy");
                    dato1 = dr[2].ToString();
                    dato2 = dr[3].ToString();
                }
                cn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private static void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object matchAllForms = false;
            object forWard = true;
            object format = false;
            object matchkashida = false;
            object matchDiactitics = false;
            object matcAlefHanza = false;
            object matchControl = false;
            object read_Only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref matchAllForms, ref forWard,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchkashida,
                ref matchDiactitics, ref matcAlefHanza,
                ref matchControl);
        }
        public static void CreateWordDocument(object filename, object saveAs, string idExamen)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing);

                myWordDoc.Activate();

                cargarDatosExamen(idExamen);

                FindAndReplace(wordApp, "<nombre>", nombre);
                FindAndReplace(wordApp, "<fecha>", fecha);

                string[] datos1 = dato1.Split('\t');
                string[] datos2 = dato2.Split('\t');
                for (int i = 0; i < datos1.Length; i++)
                {
                    FindAndReplace(wordApp, "<" + datos1[i] + ">", datos2[i]);
                }

            }
            else
                MessageBox.Show("Archivo no Encontrado");

            myWordDoc.SaveAs2(ref saveAs, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("Archivo Creado con Exito","Abrir",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
