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
    public partial class frmAgregarCur : Form
    {
        public frmAgregarCur()
        {
            InitializeComponent();
        }

        private void frmAgregarCur_Load(object sender, EventArgs e)
        {
            cbInsti.Text = "Institutos";
            cbProfesor.Text = "Profesor";
            List<Profesor> _lista = Program.colPersonas.RecuperarProfesores();
           
            
            cbProfesor.DataSource = (Program.colPersonas.RecuperarProfesores());
            cbProfesor.Text = "Profesor..";
            

            cbInsti.DataSource = (Program.colInstitutos.TablaI);
            cbInsti.DisplayMember = "Identificador";



            if (rbPropio.Checked)
            {
                gbPropio.Visible = true;
                gbConv.Visible = false;
            }
            else
            {
                gbPropio.Visible = false;
                gbConv.Visible = true;
            }
        }

        private void rbPropio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPropio.Checked)
            {
                gbPropio.Visible = true;
                gbConv.Visible = false;
            }
            else
            {
                gbPropio.Visible = false;
                gbConv.Visible = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Curso objCurso;
              

                if (rbPropio.Checked)
                {

                    objCurso = new Propio((Profesor)cbProfesor.SelectedItem, txtAula.Text, mskHora.Text, txtNomCurso.Text, mskID.Text);

                    MessageBox.Show(objCurso.ToString(), "Alta Curso Propio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

                }
                else
                {
                 

                    objCurso = new Convenio((Instituto)cbInsti.SelectedItem, txtNomCurso.Text, mskID.Text);

                    MessageBox.Show(objCurso.ToString(), "Alta Curso Convenio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                Program.colCursos.Agregar(objCurso);
            }
            mskHora.Text = "";
            mskID.Text = "";
            txtAula.Text = "";
            txtNomCurso.Text = "";
            cbInsti.Text = "Institutos";
            cbProfesor.Text = "Profesor";



           
        }


        #region Metodo
        private bool ValidarDatos()
        {
            if (txtNomCurso.Text == "")
            {
                MessageBox.Show("Usted NO ingreso el Nombre del Curso", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (!mskID.MaskFull)
            {
                MessageBox.Show("Usted NO Completo correctamente el ID del Curso", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (gbPropio.Visible == true)
            {
                if (cbProfesor.Text == "")
                {
                    MessageBox.Show("Usted NO ingreso el Nombre del Profesor", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtAula.Text == "")
                {
                    MessageBox.Show("Usted NO ingreso el Aula", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!mskHora.MaskFull)
                {
                    MessageBox.Show("La hora es Incorrecta", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (gbConv.Visible == true)
                {
                    if (cbInsti.Text == "")
                    {
                        MessageBox.Show("Usted NO ingreso el Nombre del Instituto", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }



            return true;
        }


        #endregion

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void rbConvenio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAula.Text = "";
            txtNomCurso.Text = "";
            mskHora.Text = "";
            mskID.Text = "  ";
            cbInsti.Text = " Instituto";
            cbProfesor.Text = " Profesor ";

            
            
        }
    }
}

