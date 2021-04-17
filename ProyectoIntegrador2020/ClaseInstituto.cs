using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador2020
{
    [Serializable()]
    public class ClaseInstituto
    {
        #region Atributos
        private string _IdInsti;
        private string _nombreInsti;
        private string _direcInsti;
        private string _emailInsti;
        private int _telInsti;
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
        public string   DireccionI
        {
            get { return _direcInsti; }
            set { _direcInsti = value; }
        }

        public string EmailI
        {
            get { return _emailInsti; }
            set { _emailInsti = value; }
        }
        public int TelI
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
        public ClaseInstituto () { }

       public ClaseInstituto(string nInsti)
        {
            _nombreInsti = nInsti;
        }

       public ClaseInstituto (string IDI, string nomI,string direI, string eI, int teI, string infoI)
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
            return ("Nombre Instituto " + this.NombreI  + "Identificador: " + this.IDinstituto
              + "DIRE: " + this.DireccionI+ "Email: " + this.EmailI+ "TEL: " + this.TelI + "INFO C: "+ this.InfoI );
        }


        #endregion

    }
}
