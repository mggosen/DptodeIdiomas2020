using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases2020;


namespace Clases2020
{
    [Serializable()]

    public class Persona
    {
        #region Atributos

        private string _nombre;
        private string _apellido;
        private string _email;
        private int _Dni;

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

        public int DNI
        {
            get { return _Dni; }
            set { _Dni = value;

                if (DNI <= 0) throw new Exception("DATO INVALIDO");
            
            
            }
        }

        #endregion


        #region Constructores
        public Persona() { }

        public Persona(string n)
        {
            _nombre = n;
        }

        public Persona(string nom, string ape, string email, int nroDni)
        {
            _nombre = nom;
            _apellido = ape;
            _email = email;
            _Dni = nroDni;

        }

        #endregion

        #region Consultas


        public override string ToString()
        {
            return ("Nombre: " + this.Nombre + " Apellido " + this.Apellido + ", e - mail: " + this.Email + "DNI:"+ this.DNI );

        }

        #endregion 


    }

    // --- FIN CLASE PERSONA ---//
    [Serializable()]

    public class Alumno : Persona
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

        public Alumno(int nl, DateTime f, string nom, string ape, string email, int dni) : base(nom, ape, email,dni )

        {
            _fechaIngreso = f;
            _nroLu = nl;

        }


        #endregion

        #region Consultas
       

        public override string ToString()
        {
            return (base.ToString() + "Fecha de Ingreso: " + this.FechaIngreso.ToString() + "NRO REGISTRO" + this.NroLu.ToString() );


        }

        public bool Equals(Alumno obj)
        {
            if (!(obj == null))
            {
                Alumno p_alumno = ((Alumno)obj);
                if ((this.NroLu == p_alumno.NroLu) && (this.Apellido == p_alumno.Apellido) && (this.DNI == p_alumno.DNI)
                        && (this.Email == p_alumno.Email) && (this.FechaIngreso == p_alumno.FechaIngreso)
                        && (this.Nombre == p_alumno.Nombre))
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

    }
    // --- FIN CLASE ALUMNO---//
    [Serializable()]

    public class Profesor : Persona
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
        public Profesor() : base()
        {
            _legajo = "";
            _titulouni = "";

        }

        public Profesor(string p) : base(p)
        {
            _legajo = "";
            _titulouni = "";
        }

        public Profesor(string l, string tu, string nom, string ape, string email, int dni) : base(nom, ape, email,dni)

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


    [Serializable()]
    public class Carrera

    {   

        #region Atributos
        private string _idCarrera;
        private string _nombre;
      

        #endregion

        #region propiedades
        public string Identificador
        {
            get { return _idCarrera; }
            set { _idCarrera = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }



        #endregion

        #region Constructores

        public Carrera() { }

        public Carrera(String n)
        {
            _nombre = n;
        }

        public Carrera(string n, string id)
        {

            _nombre = n;
            _idCarrera = id;
           

        }



        #endregion


        #region Consultas

        public override string ToString()
        {
            return ("Nombre de Carrera: " + this.Nombre + "Id CARRERA: " + this.Identificador );

        }



        #endregion


    }

    [Serializable()]
    public class Curso
    {
        #region Atributos

        private string _nombrecurso;
        private string _IDCurso; //identificador del curso.
        private List<Alumno> _listaAlu = null; //LISTA
      

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

        //public bool Agregar(Alumno p_alumno)
        //{
        //    if (this.ExisteInscripto(p_alumno.NroLu) == true)
        //    {
        //        return false;
        //    }
        //    else
        //    {

        //        _listaAlu.Add(p_alumno);
        //        return true;
        //    }

        //}


        public bool Agregar(Alumno p_alumno, Curso p_curso)
        {
            if ((this.ExisteCurso(p_curso.NombreCurso) == true) & (this.ExisteInscripto(p_alumno.NroLu) == true))
            {
                return false;
            }
            else
            {

                _listaAlu.Add(p_alumno);
                return true;
            }

        }

        #endregion



        #region Constructores

        public Curso()
        {
            _listaAlu = new List<Alumno>();
           
        }

     

      

        public Curso(string nc, string IDC)
        {

            _nombrecurso = nc;
            _IDCurso = IDC;
            _listaAlu = new List<Alumno>();
         

        }



        #endregion

        #region Consultas

        public override string ToString()
        {
            return ("Nombre del Curso: " + this.NombreCurso + "Identificador: " + this.Identificador + " Cant:");

        }
        public bool ExisteInscripto(int numlu)
        {

            foreach (Alumno pers in _listaAlu)
            {
                if (pers.NroLu == numlu)
                {
                    return true;

                }


            }
            return false;
          

        }

        public bool ExisteCurso(string nomcur)
        {
            foreach (Alumno cur in _listaAlu)
                if (this.NombreCurso == nomcur)
                {
                    return true;
                }

            return false;
        }

        #endregion



    }
    [Serializable()]
    public class Propio : Curso
    {
        #region Atributos
        private Profesor _profesor;
        private string _aula;
        private string _horario;

        #endregion


        #region Propiedades
        public Profesor Profesor
        {
            get { return _profesor; }
            set { _profesor = value; }
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

        public Propio() : base()
        {
            _profesor = null;

        }

        public Propio(Profesor profe, string au, string hs, string nc, string IDC) : base(nc, IDC)
        {
            _profesor = profe;
            _aula = au;
            _horario = hs;
        }

        #endregion 

        #region Consultas


        public override string ToString()
        {
            return (base.ToString() + "PROFESOR A CARGO:" + this.Profesor + "Horario : " + this.Horario + "Aula :" + this.Aula);


        }
        #endregion

    }
    [Serializable()]
    public class Convenio : Curso

    {
        #region Atributos
        private Instituto _InstiConv;

        #endregion

        #region Propiedades

        public Instituto InstitutoC
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
        public Convenio(Instituto instC, string nc, string IDC) : base(nc, IDC)
        {
            _InstiConv = instC;
        }




        #endregion

     

        #region Consultas
        public override string ToString()
        {
            return (base.ToString() + "CONVENIO: " + this.InstitutoC);


        }


        #endregion



    }
    [Serializable()]
    public class Instituto
    {
        #region Atributos
        private string _IdInsti;
        private string _nombreInsti;
        private string _direcInsti;
        private string _emailInsti;
        private string _telInsti;
        private string _infoCInsti;


        #endregion


        #region Propiedades

        public string IDinstituto
        {
            get { return _IdInsti; }
            set { _IdInsti = value; }
        }
        public string NombreI
        {
            get { return _nombreInsti; }
            set { _nombreInsti = value; }
        }
        public string DireccionI
        {
            get { return _direcInsti; }
            set { _direcInsti = value; }
        }

        public string EmailI
        {
            get { return _emailInsti; }
            set { _emailInsti = value; }
        }
        public string TelI
        {
            get { return _telInsti; }
            set { _telInsti = value; }
        }
        public string InfoI
        {
            get { return _infoCInsti; }
            set { _infoCInsti = value; }
        }




        #endregion

        #region Constructores
        public Instituto() { }

        public Instituto(string nInsti)
        {
            _nombreInsti = nInsti;
        }

        public Instituto(string IDI, string nomI, string direI, string eI, string teI, string infoI)
        {
            _IdInsti = IDI;
            _nombreInsti = nomI;
            _direcInsti = direI;
            _emailInsti = eI;
            _telInsti = teI;
            _infoCInsti = infoI;


        }



        #endregion


        #region Consultas

        public override string ToString()
        {
            return ("Nombre Instituto " + this.NombreI + "Identificador: " + this.IDinstituto
              + "DIRE: " + this.DireccionI + "Email: " + this.EmailI + "TEL: " + this.TelI + "INFO C: " + this.InfoI);
        }


        #endregion

    }
    
    
    //----------------------------------------------------------//
  
    [Serializable()]

    public class ColeccionDePersonas
    {

        #region atributos
        private List<Persona> colPersonas;

        #endregion


        #region Constructores
        public ColeccionDePersonas()
        {
            colPersonas = new List<Persona>();

         
        }

        #endregion 

        #region Propiedades
        public List<Persona> Tabla
        {
            get { return colPersonas ; }
        }


        #endregion

        #region Comandos

        public  bool AgregarP (Persona per)
        {
            if (this.ExistePersona(per.DNI)== true)
            {
                return false;
            }
            else
            { 
            colPersonas.Add(per);
                return true;
            }

        }
     

        #endregion

        #region Consultas
        public bool ExistePersona(int nro)
        {
            foreach (Persona pers in colPersonas)
            {
                if (pers.DNI == nro)
                    return true;
            }
            return false;
        }


        public List<ColeccionDePersonas> Listar()
        {
            List<ColeccionDePersonas> colPersonas = new List<ColeccionDePersonas>();
            foreach (ColeccionDePersonas pers in colPersonas)
            { 
                colPersonas.Add ((ColeccionDePersonas)pers);
            }



            return colPersonas;
        }
        public List<Alumno> RecuperarAlumnos()
        {
            List<Alumno> colAlumnos = new List<Alumno>();
            foreach (Persona Alu in colPersonas)
            {
                if (Alu.GetType() == typeof(Alumno))
                { colAlumnos.Add((Alumno)Alu); }
            }
            return colAlumnos;
        }

        public List<Profesor> RecuperarProfesores()
        {
            List<Profesor> colProfesores = new List<Profesor>();
            foreach (Persona Prof in colPersonas)
            {
                if (Prof.GetType() == typeof(Profesor))
                { colProfesores.Add((Profesor)Prof); }
            }
            return colProfesores;
        }

        public Persona ConsultaDNI(int nro)
        {

            foreach (Persona dnipers in colPersonas)
            {
                if (dnipers.DNI == nro)

                    return dnipers;

            }

            return null;

        }
       public Alumno ConsultaLU(int Alu)
        {
            foreach (Alumno nroLU in colPersonas)
            {
                if (nroLU.NroLu == Alu)
                    return nroLU;

            }

            return null;



        }

        public Persona EliminarPersona( int numdni)
        {
            for (int i = 0; i < colPersonas.Count; i++)
            {
                if (colPersonas[i] == ConsultaDNI(numdni))
                    colPersonas.RemoveAt(i);



            }

            return null;

            //List<Persona> itemsToRemove = new List<Persona>();
            //for (int i = 0; i < lista.Count; i++)
            //{
            //    if (lista[i] == ConsultaDNI(numdni))
            //       lista.RemoveAt(i);



            //}


            //return null;

        }

        public List<Alumno> RecuperarAluPorNombre(string nom )
        {
            List<Alumno> colAlumnos = new List<Alumno>();
            foreach (Persona Alu in colPersonas)
            {
                if (Alu.GetType() == typeof(Alumno))

                {
                    //if (Alu.Nombre == nom) 
                    if ((Alu.Nombre.IndexOf(nom) > -1 ) || (Alu.Apellido.IndexOf(nom) > -1))
                    {
                        colAlumnos.Add((Alumno)Alu);
                    }
                }
            }
            return colAlumnos;
        }

        public List<Profesor> RecuperarProfPorNombre(string nom)
        {
            List<Profesor> colProfesor = new List<Profesor>();
            foreach (Persona Prof in colPersonas)
            {
                if (Prof.GetType() == typeof(Profesor))

                {
                    //if (Alu.Nombre == nom) 
                    if ((Prof.Nombre.IndexOf(nom) > -1) || (Prof.Apellido.IndexOf(nom) > -1))
                    {
                        colProfesor.Add((Profesor)Prof);
                    }
                }
            }
            return colProfesor;
        }

        #endregion


    }
    [Serializable()]
    public class ColeccionDeCarreras
    {
        #region Atributos

        private List<Carrera> colCarreras;

        #endregion

        #region Constructores
        public ColeccionDeCarreras()
        {
            colCarreras = new List<Carrera>();

            colCarreras.Add(new Carrera("Abogacia", "001"));
            colCarreras.Add(new Carrera("Arquitectura", "002"));
            colCarreras.Add(new Carrera("Contador", "003"));
            colCarreras.Add(new Carrera("Lic. en Computacion", "004"));
            colCarreras.Add(new Carrera("Medicina", "005"));
            colCarreras.Add(new Carrera("TUSEII", "006"));




        }

        #endregion

        #region Propiedades
        public List<Carrera> TablaC
        {
            get { return colCarreras; }
        }


        #endregion

        #region Comandos

        public bool AgregarCarrera(Carrera c)
        {
            if ( ExisteCarrera (c.Identificador )==true)
            {
               
                return false;
                
            }
            else
            {
                colCarreras.Add(c);
                return true;
            }
        }


        #endregion

        #region Metodos Auxiliares

        public bool ExisteCarrera (string e )
        {
            foreach (Carrera ecarrera in colCarreras)
            {
                if (ecarrera.Identificador == e)
                    return true;
            }
            return false;
        }
        #endregion
    }
    [Serializable()]
    public class ColeccionDeInstitutos
    {
        #region Atributos
        private List<Instituto> colInstitutos;
        #endregion

        #region Constructores

        public ColeccionDeInstitutos()
        {
        colInstitutos = new List<Instituto>();

            colInstitutos.Add (new Instituto ("AES8000", "Sociedad Escolar Alemana", "Moreno 540", "contacto@seabblanca.com.ar", "Tel: 291-4536007", "Instagram:@sociedadescolaralemana"));
            colInstitutos.Add(new Instituto("ADA8000", "Asociación Dante Alighieri", "Rondeau 26", "secretaria@ladantebblanca.com.ar", "Tel: 291-4523305", "Facebook: LA DANTE B.B"));
            colInstitutos.Add(new Instituto("JBA8000", "Alianza Francesa", "Fitz Roy 49", "secretariaalianzabhi@gmail.com", "Tel: 2914232795", "FB/IG: @alianzafrancesa.bahiablanca"));
        }
        #endregion

        #region Propiedades
        public List<Instituto> TablaI
        {
            get { return colInstitutos; }
        }

        #endregion

        #region Comandos

        public bool AgregarInsti(Instituto i)
        {
            if (ExisteInsti(i))
            {
                MessageBox.Show("Codigo duplicado de Instituto!");
                return false;
            }
            else
            {
                colInstitutos.Add(i);
                return true;
            }
        }



        #endregion

        #region Metodos Auxiliares

        public bool ExisteInsti(Instituto exi)
        {
            foreach (Instituto i in colInstitutos)
            {
                if (exi.IDinstituto == i.IDinstituto)
                    return true;
            }
            return false;
        }
        #endregion
    }
    [Serializable()]
    public class ColeccionDeCursos
    {
        #region Atributos

        private List<Curso> colCurso;

        #endregion

        #region Constructores


        public ColeccionDeCursos()
        {
            colCurso = new List<Curso>();

            colCurso.Add(new Curso("Inglés como Lengua Extranjera (ILE) - Niveles IA", "001"));
            colCurso.Add(new Curso("Inglés como Lengua Extranjera (ILE) - Niveles IIA", "002"));
            colCurso.Add(new Curso("Inglés como Lengua Extranjera (ILE) - Niveles IIIA", "003"));
            colCurso.Add(new Curso("Lectura Comprensiva de Textos en Inglés - Niveles I", "004"));
            colCurso.Add(new Curso("Lectura Comprensiva de Textos en Inglés - Niveles II", "005"));
            colCurso.Add(new Curso("Lectura Comprensiva de Textos en Inglés - Niveles III", "006"));
            colCurso.Add(new Curso("Italiano I ", "007"));
            colCurso.Add(new Curso("Italiano II", "008"));
            colCurso.Add(new Curso("Italiano III", "009"));
            colCurso.Add(new Curso("Frances I", "010"));
            colCurso.Add(new Curso("Frances II", "011"));
            colCurso.Add(new Curso("Frances III", "012"));
            colCurso.Add(new Curso("Aleman I", "013"));
            colCurso.Add(new Curso("Aleman II", "014"));
            colCurso.Add(new Curso("Aleman III", "013"));

        }


        #endregion


        #region Propiedades
        public List<Curso> Tabla
        {


            get { return colCurso; }


        }

        #endregion


        #region Comandos
        public void Agregar(Curso p_curso)
        {


            if (this.ExisteCurso(p_curso.Identificador))
            {
                MessageBox.Show("El curso ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                colCurso.Add(p_curso);
            }


        }


        #endregion

        #region consultas

        public List<Propio> RecuperarCursoPropio()
        {
            List<Propio> colCurso = new List<Propio>();
            foreach (Curso Propio in colCurso)
            {
                if (Propio.GetType() == typeof(Propio))
                { colCurso.Add((Propio)Propio); }
            }
            return colCurso;
        }

        public List<Convenio> RecuperarCursoConvenio()
        {
            List<Convenio> colCurso = new List<Convenio>();
            foreach (Curso Con in colCurso)
            {
                if (Con.GetType() == typeof(Convenio))
                { colCurso.Add((Convenio)Con); }
            }
            return colCurso;
        }

        public List<Convenio> BuscarCursoporConv(Instituto p_insti)
        {
            {

                List<Convenio> _cursConv = new List<Convenio>();

                foreach (Curso cur in colCurso)
                {
                    if (cur.GetType() == typeof(Convenio))
                    {
                        Convenio c = (Convenio)cur;
                        if (c.InstitutoC == p_insti)
                            _cursConv.Add(c);
                    }
                }

                return _cursConv;
            }

        }

        public List<Propio> BuscarCursoporProf(Profesor p_prof)
        {
            {
                
                List<Propio> _cursos = new List<Propio>();

                foreach (Curso curso in colCurso)
                {
                    if (curso.GetType() == typeof(Propio))
                    {
                        Propio p = (Propio)curso;  
                        if (p.Profesor == p_prof)
                        _cursos.Add(p);
                    }
                }

                return _cursos;
            }
        }
        public List<Curso> RecuperarCursoPorNom(string nom)
        {
            List<Curso> _cursos = new List<Curso>();
            foreach (Curso cur in this.colCurso)
            {
                //if (cur.GetType() == typeof(Curso))

                //{
                    //if (Alu.Nombre == nom) 
                    if ((cur.NombreCurso.ToLower().Contains(nom.ToLower()))) 
                    {
                        _cursos.Add((Curso)cur);
                   }
               // }
            }
            return _cursos;
        }




        //public List<Curso> BuscarCursoporAlumno(Alumno p_alu)
        //{
        //    List<Curso> _cursos = new List<Curso>();
        //    foreach (Curso curso in this.colCurso)
        //    {
        //        foreach (Alumno objAlumno in curso.alumnos)  
        //        {
        //            if (objAlumno == p_alu)
        //            {
        //                _cursos.Add(curso);
        //            }
        //        }
        //    }
        //    return _cursos;
        //}
        public List<Curso> BuscarCursoporAlumno(Alumno p_alu)
        {
            List<Curso> _cursos = new List<Curso>();
            foreach (Curso curso in this.colCurso)
            {
                foreach (Alumno objAlumno in curso.alumnos)
                {
                    if (objAlumno.Equals(p_alu))
                    {
                        _cursos.Add(curso);
                    }
                }
            }
            return _cursos;
        }





        public List<ColeccionDeCursos> Listar()
        {
            List<ColeccionDeCursos> colPersonas = new List<ColeccionDeCursos>();
            foreach (ColeccionDeCursos pers in colPersonas)
            {
                colPersonas.Add((ColeccionDeCursos)pers);
            }



            return colPersonas;
        }


        #endregion

        #region Metodos Auxiliares
        public bool ExisteCurso(string nro)
        {
            foreach (Curso IDCurso in colCurso)
            {
                if (IDCurso.Identificador == nro)
                    return true;
            }
            return false;
        }

        #endregion
    }
}
