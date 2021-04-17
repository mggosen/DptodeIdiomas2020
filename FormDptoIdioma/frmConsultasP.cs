using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases2020;

namespace FormDptoIdioma
{
    public partial class frmConsultasP : Form
    {
        public frmConsultasP()
        {
            InitializeComponent();
        }

        private void rbProfesor_CheckedChanged(object sender, EventArgs e)
        {
            List<Profesor> _lista = Program.colPersonas.RecuperarProfesores();
            lstPersonas.Items.Clear();
            foreach (Profesor obj in _lista)
            {
                lstPersonas.Items.Add(obj.ToString());
            
            
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
           
            lstPersonas.Items.Clear();
            Persona objpersona;
            int nrodni = Convert.ToInt32(mskDNI.Text);
            objpersona = Program.colPersonas.ConsultaDNI(nrodni);
            {

                lstPersonas.Items.Add(objpersona.ToString());
                MessageBox.Show(objpersona.ToString(), "BUSQUEDA PERSONA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

           
           mskDNI.Text = "";
        }

        private void rbAlumnos_CheckedChanged(object sender, EventArgs e)
        {
            List<Alumno> _lista = Program.colPersonas.RecuperarAlumnos();
           lstPersonas.Items.Clear();
            foreach (Alumno obj in _lista)
            {
                lstPersonas.Items.Add(obj.ToString());

            }

        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Persona elem in Program.colPersonas.Tabla)
            {
                lstPersonas.Items.Add(elem.ToString());
            
            
            }


        }

        private void frmConsultasP_Load(object sender, EventArgs e)
        {
       
    
        }

        private void bntVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            lstPersonas.Items.Clear();  
            Persona objpersona;
           
            int nrodni = Convert.ToInt32(mskeliminar.Text);
            objpersona = Program.colPersonas.EliminarPersona(nrodni);
          
            {
               
                MessageBox.Show("eliminar"," PERSONA ELIMINADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
          
           mskeliminar.Text = "";


        }
    }
}
