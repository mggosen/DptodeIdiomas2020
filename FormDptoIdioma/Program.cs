using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases2020;

namespace FormDptoIdioma
{
    static class Program
    {
        internal static ColeccionDePersonas colPersonas = new ColeccionDePersonas();
        internal static ColeccionDeCarreras colCarreras = new ColeccionDeCarreras();
        internal static ColeccionDeInstitutos colInstitutos = new ColeccionDeInstitutos();
        internal static ColeccionDeCursos colCursos = new ColeccionDeCursos();
        internal static Curso  _listaAlu = new Curso();


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Persona objPers1 = new Persona();
            Profesor objProfe1 = new Profesor();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenuDpto());
        }
    }
}
