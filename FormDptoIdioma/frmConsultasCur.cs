using Clases2020;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDptoIdioma
{
    public partial class frmConsultasCur : Form
    {
        public frmConsultasCur()
        {
            InitializeComponent();
        }

        private void rbPropio_CheckedChanged(object sender, EventArgs e)
        {
            
                gbPropio.Enabled = true;
                gbConv.Enabled = false;
                gbAlumno.Enabled = false;
            
            

        }

        private void frmConsultasCur_Load(object sender, EventArgs e)
        {
            cbNroLu.DataSource = Program.colPersonas.RecuperarAlumnos();
            cbNroLu.DisplayMember = "Nombre";
            cbNroLu.Text = "Alumnos";

            cbProfesor.DataSource = Program.colPersonas.RecuperarProfesores();
            cbProfesor.DisplayMember = "Nombre";

            cbIDInsti.DataSource = Program.colInstitutos.TablaI;
            cbIDInsti.DisplayMember = "nombreInsti";

            gbAlumno.Enabled = true;
            gbConv.Enabled = false;
            gbPropio.Enabled = false;

            

        }

        private void rbConvenio_CheckedChanged(object sender, EventArgs e)
        {
            
                gbPropio.Enabled = false;
                gbConv.Enabled = true;
                gbAlumno.Enabled = false;
          

        }

        private void btnProfe_Click(object sender, EventArgs e)
        {
            lstCursos.Items.Clear();
            lstCursos.DataSource = Program.colCursos.BuscarCursoporProf((Profesor)cbProfesor.SelectedItem);

        }

        private void btnInsti_Click(object sender, EventArgs e)
        {

            lstCursos.Items.Clear();
            lstCursos.DataSource = Program.colCursos.BuscarCursoporConv((Instituto)cbIDInsti.SelectedItem);
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

          
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAlu_Click(object sender, EventArgs e)
        {
            Alumno objalu = (Alumno)cbNroLu.SelectedItem;

         
            lstCursos.DataSource= Program.colCursos.BuscarCursoporAlumno(objalu);
           // lstCursos.Items.Add(Program.colCursos.BuscarCursoporAlumno(objalu));
            MessageBox.Show("" );
     
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {

          

            gbAlumno.Enabled = true;
                gbPropio.Enabled = false;
                gbConv.Enabled = false;
            


        }
    }
}
