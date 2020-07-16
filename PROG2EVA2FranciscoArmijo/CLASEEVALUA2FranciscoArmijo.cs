using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2EVA2FranciscoArmijo
{
    class CLASEEVALUA2FranciscoArmijo
    {
        private string rut;
        private DateTime InicioSesion;
        private DateTime FinSesion;
        private string Accion;
        private DateTime AccionF;
        private string clave;

        public CLASEEVALUA2FranciscoArmijo()
        {
            this.rut = "";
            this.Accion = "";
            this.clave = "";
        }

       
        
        public string RUT
        {
            get { return rut; }
            set { this.rut = value; }
        }

        public string CLAVE
        {
            get { return clave; }
            set { this.clave = value; }
        }
        public DateTime DATEINICIO
        {
            get { return InicioSesion; }
            set { this.InicioSesion = value; }
        }

        public string ACCION
        {
            get { return Accion; }
            set { this.Accion = value; }
        }

        public DateTime DATEACCION
        {
            get { return AccionF; }
            set { this.AccionF = value; }
        }

        public DateTime DATEFIN
        {
            get { return FinSesion; }
            set { this.FinSesion = value; }
        }


    }
}
