using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador2020
{
    [Serializable()]
    public class ClaseCurso
    {
        #region Atributos

        private string _nombrecurso;
        private string _IDCurso; //identificador del curso.
        private List<Alumno> _listaAlu= null; //LISTA


        #endregion


        #region Propiedades
        public int CantAlu
        {
            get { return _listaAlu.Count; }

        }
        public string NombreCurso
        {
            get { return _nombrecurso; }
            set { _nombrecurso = value; }
        }

        public string Identificador
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }

        public List<Alumno> alumnos
        {
            get { return _listaAlu; }
          
        }


        #endregion

        #region Comandos

        public void Agregar(Alumno p_alumno)
        {
            _listaAlu.Add(p_alumno);
       
        }

        #endregion


        #region Constructores

        public ClaseCurso() 
        {
            _listaAlu = new List<Alumno>();
        }

        public ClaseCurso (string  nc)
        {

            _nombrecurso = nc;
            _listaAlu = new List<Alumno>();
        }

        public ClaseCurso(string nc, string IDC )
        {
        
            _nombrecurso = nc;
            _IDCurso = IDC;
            _listaAlu = new List<Alumno>();

         }



        #endregion

        #region Consultas

        public override string ToString()
        {
            return ("Nombre del Curso: "+ this.NombreCurso + "Identificador: "+ this.Identificador + " Cant:" );

        }



        #endregion



    }
    [Serializable()]
    public class Propio : ClaseCurso
    {
        #region Atributos
        private Profesor _profesor;
        private string _aula;
        private string _horario;

        #endregion


        #region Propiedades
        public Profesor  Profesor 
        {
            get { return _profesor ; }
            set { _profesor= value; }
        }

        public string Aula
        {
            get { return _aula; }
            set { _aula = value; }
        }
        public string Horario
        {
            get { return _horario; }
            set { _horario = value; }
        }



        #endregion

        #region Constructores

        public Propio () : base()
        {
            _profesor = null;
            
        }
       
        public Propio(Profesor  profe,  string au, string hs, string nc, string IDC) : base ( nc,   IDC)
        {
            _profesor = profe;
            _aula = au;
            _horario = hs;
        }

        #endregion 

        #region Consultas


        public override string ToString()
        {
            return (base.ToString() + "PROFESOR A CARGO:" + this.Profesor + "Horario : " + this.Horario + "Aula :" + this.Aula );


        }
        #endregion

    }
    [Serializable()]
    public class Convenio : ClaseCurso
    
    {
        #region Atributos
        private ClaseInstituto _InstiConv;

        #endregion

        #region Propiedades

        public ClaseInstituto  InstitutoC
        {
            get { return _InstiConv; }
            set { _InstiConv = value; }
        }

        #endregion

        #region Constructores
        public Convenio() : base()
        {
            _InstiConv = null; 
        }
        public Convenio (ClaseInstituto instC, string nc, string IDC) : base(nc, IDC)
        {
            _InstiConv = instC;
        }




        #endregion

        #region Comandos


        #endregion

        #region Consultas
        public override string ToString()
        {
            return (base.ToString() + "CONVENIO: " + this.InstitutoC );


        }


        #endregion



    }
   
    
    //---Coleccion --- //
    
    [Serializable()]
    public class ColeccionAlumnos //ALUMNO GRAL
    {
        #region Atributos
        private List<Alumno> listaAlugral;

        #endregion

        #region Constructores

        public ColeccionAlumnos()
        {
            listaAlugral = new List<Alumno>();

        }

        #endregion


        #region Propiedades
        public List<Alumno> _alumnos
        {


            get { return listaAlugral; }


        }

        #endregion


        #region Comandos
        public void Agregar(Alumno p_alumno)
        {
            listaAlugral.Add(p_alumno);

        }


        #endregion 

    }


}
