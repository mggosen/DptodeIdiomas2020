using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador2020
{
    [Serializable()]
    public class ClaseCarrera
    {

        #region Atributos
        private string _identificador;
        private string _nombre;
        private string _departamento;

        #endregion

        #region propiedades
        public string Identificador
        {
            get { return _identificador; }
            set { _identificador = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }


        #endregion

        #region Constructores

        public ClaseCarrera() { }

        public ClaseCarrera(String n)
        {
            _nombre = n;
        }

        public ClaseCarrera(string n, string id, string dpto)
        {

            _nombre = n;
            _identificador = id;
            _departamento = dpto;

        }



        #endregion


        #region Consultas

        public override string ToString()
        {
            return ("Nombre de Carrera: " + this.Nombre + "Identificador: " + this.Identificador + "Departamento" + this.Departamento);

        }



        #endregion




    }
}
