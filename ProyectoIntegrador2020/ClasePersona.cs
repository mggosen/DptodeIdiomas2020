using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador2020
{
    [Serializable()]

    public class ClasePersona
    {
        #region Atributos

        private string _nombre;
        private string _apellido;
        private string _email;


        #endregion


        #region Propiedades
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }



        #endregion


        #region Constructores
        public ClasePersona() { }

        public ClasePersona(string n)
        {
            _nombre = n;
        }

        public ClasePersona(string nom, string ape, string email)
        {
            _nombre = nom;
            _apellido = ape;
            _email = email;

        }

        #endregion

        #region Consultas


        public override string ToString()
        {
            return ("Nombre: " + this.Nombre + " Apellido " + this.Apellido + ", e - mail: " + this.Email);

        }

        #endregion 


    }

    // --- FIN CLASE PERSONA ---//
    [Serializable()]

    public class Alumno : ClasePersona
    {

        #region Atributos

        private DateTime _fechaIngreso;//VER AÑO INSCRIPCION.
        private int _nroLu;
      //  private Carrera : _carrera;

        #endregion  //VER CARRERA DE TIPO CARRERA

        #region Propiedades
        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
            set { _fechaIngreso = value; }
        }
        public int NroLu
        {
            get { return _nroLu; }
            set { _nroLu = value; }
        }


        #endregion //PROPIEDAD CARRERA

        #region Constructores
        public Alumno() : base()
        {
            _fechaIngreso = DateTime.Now;
            _nroLu = 0;

        }
            
        public Alumno(string a) : base(a)
        {
            _fechaIngreso = DateTime.Now;
            _nroLu = 0;

        }

        public Alumno(int nl, DateTime f, string nom, string ape, string email) : base(nom, ape, email)

        {
            _fechaIngreso = f;
            _nroLu = nl;

        }


        #endregion

        #region Consultas


        public override string ToString()
        {
            return (base.ToString() + "Fecha de Ingreso: " + this.FechaIngreso.ToString() + "NRO REGISTRO" + this.NroLu.ToString());


        }

        #endregion

    }
    // --- FIN CLASE ALUMNO---//
    [Serializable()]

    public class Profesor : ClasePersona
    {
        #region Atributos
        private string _legajo;
        private string _titulouni;



        #endregion


        #region Propiedades
        public string Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }
        public string TituloUni
        {
            get { return _titulouni; }
            set { _titulouni = value; }
        }


        #endregion


        #region Constructores
        public Profesor () : base()
        {
            _legajo = "";
            _titulouni = "";

        }

        public Profesor(string p) : base(p)
        {
            _legajo = "";
            _titulouni = "";
        }

        public Profesor (string l,string tu, string nom, string ape, string email) : base(nom, ape, email)

        {
            _legajo = l;
            _titulouni = tu;

        }




        #endregion


        #region Consultas

        public override string ToString()
        {
            return (base.ToString() + "Nro Legajo: " + this.Legajo.ToString() + "Titulo Universitario: " + this.TituloUni.ToString());


        }
        #endregion 







    }

    // --- FIN CLASE PROFESOR---//

  
   



}
