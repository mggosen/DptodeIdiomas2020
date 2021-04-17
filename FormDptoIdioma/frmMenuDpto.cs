using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases2020;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FormDptoIdioma
{
    public partial class frmMenuDpto : Form
    {
        public frmMenuDpto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          


        }

        private void btnDpto_Click(object sender, EventArgs e)
        {

            frmInfo formulario = new frmInfo();
            formulario.ShowDialog();

        }

        private void añadirPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarP formAgregar = new frmAgregarP();
            formAgregar.ShowDialog();
        }

        private void consultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultasP formConsultar = new frmConsultasP();
            formConsultar.ShowDialog();
        }

        private void agregarCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCarr formAgr = new frmAgregarCarr();
            formAgr.ShowDialog();

        }

        private void añadirCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCur formcur = new frmAgregarCur();
            formcur.ShowDialog();
        }

        private void añadirAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarAlu formagregaralumno = new frmAgregarAlu();
            formagregaralumno.ShowDialog();
        }

        private void consultasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultasCur frm = new frmConsultasCur();
            frm.ShowDialog();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alumnoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
       
        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void personaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscar10 buscarP = new frmBuscar10();
            buscarP.ShowDialog();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void añadirInstitutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarI agr = new frmAgregarI();
            agr.ShowDialog();
        }

        private void frmMenuDpto_Load(object sender, EventArgs e)
        {
            string nomArchivo = Application.StartupPath + "\\colPersona.bin";
            if (File.Exists(nomArchivo))
            {
                Stream objStream = File.OpenRead(nomArchivo);
                BinaryFormatter objDeerializacion = new BinaryFormatter();
                Program.colPersonas= (ColeccionDePersonas) objDeerializacion.Deserialize (objStream);
                objStream.Close();
              //  MessageBox.Show("Personas leidas desde el Archivo " + nomArchivo);

            }
            string nomArchivoCursos = Application.StartupPath + "\\colCurso.bin";
            if (File.Exists(nomArchivoCursos))
            {
                Stream objStream = File.OpenRead(nomArchivoCursos);
                BinaryFormatter objDeerializacion = new BinaryFormatter();
                Program.colCursos = (ColeccionDeCursos)objDeerializacion.Deserialize(objStream);
                objStream.Close();
                //  MessageBox.Show("Cursos leidos desde el Archivo " + nomArchivoCursos);

            }
            string nomArchivoCarr = Application.StartupPath + "\\colCarrera.bin";
            if (File.Exists(nomArchivoCarr))
            {
                Stream objStream = File.OpenRead(nomArchivoCarr);
                BinaryFormatter objDeerializacion = new BinaryFormatter();
                Program.colCarreras = (ColeccionDeCarreras)objDeerializacion.Deserialize(objStream);
                objStream.Close();
                // MessageBox.Show("Carreras leidas desde el Archivo " + nomArchivoCarr);

            }
            string nomArchivoInsti = Application.StartupPath + "\\colInsti.bin";
            if (File.Exists(nomArchivoInsti))
            {
                Stream objStream = File.OpenRead(nomArchivoInsti);
                BinaryFormatter objDeerializacion = new BinaryFormatter();
                Program.colInstitutos = (ColeccionDeInstitutos)objDeerializacion.Deserialize(objStream);
                objStream.Close();
                // MessageBox.Show("Institutos leidos desde el Archivo " + nomArchivoInsti);

            }
        }

        private void frmMenuDpto_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ---- ARCHIVO PERSONAS ---- //
            string nomArchivo = Application.StartupPath + "\\colPersona.bin";
            Stream objStream = File.OpenWrite(nomArchivo);
            BinaryFormatter objSerializacion = new BinaryFormatter();
            objSerializacion.Serialize(objStream, Program.colPersonas);
            objStream.Close();
             MessageBox.Show("Personas Guardadas en " + nomArchivo);

            // ---ARCHIVO CURSOS ---- //
            string nomArchivoCursos = Application.StartupPath + "\\colCurso.bin";
             objStream = File.OpenWrite(nomArchivoCursos);
            
            objSerializacion.Serialize(objStream, Program.colCursos);
            objStream.Close();
            MessageBox.Show("Cursos Guardados en " + nomArchivoCursos);

            //----ARCHIVO CARRERAS ---- //
            string nomArchivoCarr = Application.StartupPath + "\\colCarrera.bin";
            objStream = File.OpenWrite(nomArchivoCarr);
            
            objSerializacion.Serialize(objStream, Program.colCarreras);
            objStream.Close();
            MessageBox.Show("Carreras Guardadas en " + nomArchivoCarr);

            //------ARCHIVO INSTITUTOS ----//
            string nomArchivoInsti = Application.StartupPath + "\\colInsti.bin";
            objStream = File.OpenWrite(nomArchivoInsti);
           
            objSerializacion.Serialize(objStream, Program.colInstitutos);
            objStream.Close();
            MessageBox.Show("Carreras Guardadas en " + nomArchivoInsti);

        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
