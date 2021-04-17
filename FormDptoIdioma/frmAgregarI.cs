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
using Clases2020;


namespace FormDptoIdioma
{
    public partial class frmAgregarI : Form
    {
        public frmAgregarI()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {

                Instituto objInstituto;

                objInstituto = new Instituto(mskIDInst.Text, txtNombre.Text, txtDireccion.Text, txtEmail.Text, mskTelefono.Text, txtinfoC.Text);

                MessageBox.Show(objInstituto.ToString(), "Ingreso Nuevo Instituto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.colInstitutos.AgregarInsti(objInstituto);


            }
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtinfoC.Text = "";
            txtNombre.Text = "";
            mskIDInst.Text = "";
            mskTelefono.Text = "";
        }
        #region Metodos
        public bool ValidarDatos()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Usted NO ingreso el nombre de la Institucion", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!mskIDInst.MaskFull)
            {
                MessageBox.Show("Usted NO ingreso los datos del ID correctamente", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Usted NO ingreso la direccion de la Institucion", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ValidarFormatoCorreo(txtEmail.Text) == false)
            {
                MessageBox.Show("El e-mail ingresado tiene el formato incorrecto", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!mskTelefono.MaskFull)
            {
                MessageBox.Show("El telefono ingresado es incorrecto", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtinfoC.Text == "")
            {
                MessageBox.Show("Usted NO ingreso la informacion del contacto", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private Boolean ValidarFormatoCorreo(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
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

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtinfoC.Text = "";
            txtNombre.Text = "";
            mskIDInst.Text = "";
            mskTelefono.Text = "";

        }
    }
}
