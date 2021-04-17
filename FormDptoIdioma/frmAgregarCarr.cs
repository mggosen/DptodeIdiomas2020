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
    public partial class frmAgregarCarr : Form
    {
        public frmAgregarCarr()
        {
            InitializeComponent();
        }

        #region Metodo
        private bool ValidarDatos()
        {
            if (!mskBtnID.MaskFull)
            {
                MessageBox.Show("Ingreso un ID invalido", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNomCarr.Text == "")
            {
                MessageBox.Show("No completo el Nombre de la carrera", "Formulario Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        #endregion


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelBtn.Visible = false;
            panelCampos.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                Carrera objCarrera;

                objCarrera = new Carrera(txtNomCarr.Text, mskBtnID.Text);
                if (Program.colCarreras.AgregarCarrera(objCarrera))
                {


                    lstCarreras.Items.Add(objCarrera.ToString());
                    MessageBox.Show(objCarrera.ToString(), "Ingreso Nueva Carrera", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show( "ERROR","ID DUPLICADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
            txtNomCarr.Text = "";
            mskBtnID.Text = "";
            panelCampos.Visible = false;
            panelBtn.Visible = true;
        }

        private void AgregarCarr_Load(object sender, EventArgs e)
        {
            panelCampos.Visible = false;

            foreach (Carrera elemento in Program.colCarreras.TablaC)
            {
                lstCarreras.Items.Add(elemento.ToString());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomCarr.Text = "";
            mskBtnID.Text = "";
        }
    }
}
