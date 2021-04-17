using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases2020;

namespace FormDptoIdioma
{
    public partial class frmAgregarAlu : Form
    {
        public frmAgregarAlu()
        {
            InitializeComponent();
        }

        private void frmAgregarAlu_Load(object sender, EventArgs e)
        {
            gpAñadir.Visible = false;
            cbLU.DataSource = Program.colPersonas.RecuperarAlumnos();
            cbLU.DisplayMember = "NroLu";



            cbCursos.DataSource = (Program.colCursos.Tabla);
            cbCursos.DisplayMember = "NombreCurso";


            List<Alumno> _lista = Program.colPersonas.RecuperarAlumnos();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbLU.Text = "LU";
            cbCursos.Text = "Cursos";

            gpAñadir.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            gpAñadir.Visible = true;




        }



        private void btnConfirmar_Click(object sender, EventArgs e)
        {


            Alumno objalu;
            Curso objCurso;
            objalu = ((Alumno)cbLU.SelectedItem);
            objCurso = ((Curso)cbCursos.SelectedItem);
            if (objCurso.Agregar(objalu,objCurso))
            {
                lstAlumnoencurso.Items.Add(objalu.ToString());
                MessageBox.Show("ALUMNO AGREGADO", "REGISTRAR ALUMNO ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Ya estaba inscripto el alumno", "REGISTRAR ALUMNO ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }
    }
}
