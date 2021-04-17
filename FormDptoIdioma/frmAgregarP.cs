using Clases2020;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormDptoIdioma
{
    public partial class frmAgregarP : Form
    {
      
        public frmAgregarP()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.ValidarDatos())
            {
                Persona objPersona;
                if (rbAlumno.Checked)
                {

                    DateTime d = DateTime.Parse(mskTxtFecha.Text);
                    int dni = System.Convert.ToInt32(mskTxtDNI.Text);
                    int LU = System.Convert.ToInt32(mskTxtLu.Text);



                    objPersona = new Alumno(LU, d, txtNombre.Text, txtApellido.Text, txtEmail.Text, dni);

                    if (Program.colPersonas.AgregarP(objPersona))
                    {
                        MessageBox.Show(objPersona.ToString(), "Alta Alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El alumno ya esta inscrito", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    int dni = System.Convert.ToInt32(mskTxtDNI.Text);

                    objPersona = new Profesor(mskTxtNroLegajo.Text, txtTuni.Text, txtNombre.Text, txtApellido.Text,
                    txtEmail.Text, dni);


                    if (Program.colPersonas.AgregarP(objPersona))
                    {
                        MessageBox.Show(objPersona.ToString(), "Alta Profesor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El Profesor ya esta inscrito", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


                rbAlumno.Checked = true;
                txtApellido.Text = "";
                txtEmail.Text = "";
                txtNombre.Text = "";
                txtTuni.Text = "";
                mskTxtDNI.Text = "";
                mskTxtFecha.Text = "";
                mskTxtLu.Text = "";
                mskTxtNroLegajo.Text = "";
            }


        


    }

        #region Metodos Aux 

        private bool ValidarDatos()
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Usted NO ingreso ningun nombre", "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Usted NO ingreso ningun Apellido", "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!mskTxtDNI.MaskFull)
            {
                MessageBox.Show("El DNI ingresado es incorrecto", "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //if (ValidarFormatoCorreo(txtEmail.Text) == false)
            //{
            //    MessageBox.Show("El Email Ingresado no se encuentra en el Formato Correcto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //    return false;

            //}
            if (gbAlu.Visible == true)
            {
                if (!mskTxtLu.MaskFull)
                {
                    MessageBox.Show("El LU ingresado es incorrecto", "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!EsFecha(mskTxtFecha.Text))
                {
                    MessageBox.Show("La fecha seleccionada no es Valida", "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


            }
            if (gbProfesor.Visible == true)
            {
                if (txtTuni.Text == "")
                {
                    MessageBox.Show("Usted no ingreso el Titulo Universitario", "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!mskTxtNroLegajo.MaskFull)
                {
                    MessageBox.Show("El Numero de Legajo ingresado esta incompleto", "Campo Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

       public static Boolean ValidarFormatoCorreo(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)@\\w+([-.]\\w+)\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static Boolean EsFecha(string fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }


        #endregion


        private void btnReset_Click(object sender, EventArgs e)
        {
            rbAlumno.Checked = true;
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtTuni.Text = "";
            mskTxtDNI.Text = "";
            mskTxtFecha.Text = "";
            mskTxtLu.Text = "";
            mskTxtNroLegajo.Text = "";
        }

        private void frmAgregarP_Load(object sender, EventArgs e)
        {
           


            if (rbAlumno.Checked)

                {
                    gbAlu.Visible = true;
                    gbProfesor.Visible = false;
                }
                else
                {
                gbAlu.Visible = false;
                gbProfesor.Visible = true;
                }
            
        }

        private void rbAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlumno.Checked)
            {
                gbAlu.Visible = true;
                gbProfesor.Visible = false;
            }
            else
            {
                gbAlu.Visible = false;
                gbProfesor.Visible = true;
            }
        }
    }
}
