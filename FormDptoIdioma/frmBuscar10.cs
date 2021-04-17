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
    public partial class frmBuscar10 : Form
    {
        public frmBuscar10()
        {
            InitializeComponent();
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbAlumnos.Checked==true)
            {
                lstListar.DataSource = null;
                lstListar.DataSource = Program.colPersonas.RecuperarAluPorNombre(txtBuscar.Text);
               
            }
            if (rbProfesor.Checked == true)
            {
                lstListar.DataSource = null;
                lstListar.DataSource = Program.colPersonas.RecuperarProfPorNombre(txtBuscar.Text);   
            }
            if (rbCursos.Checked == true)
            {
                lstListar.DataSource = null;
                lstListar.DataSource = Program.colCursos.RecuperarCursoPorNom(txtBuscar.Text);
            }
            txtBuscar.Text = "";

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
