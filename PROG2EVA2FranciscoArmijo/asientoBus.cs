using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2EVA2FranciscoArmijo
{
    class asientoBus
    {
        private bool ocupado;
        private string usuario;
        private string rutUsuario;
        private int asiento;

        public asientoBus()
        {
            this.ocupado = false;
            this.usuario = "";
            this.rutUsuario = "";
            this.asiento = 0;
        }

       public void reiniciar()
        {
            this.ocupado = false;
            this.usuario = "";
            this.rutUsuario = "";
            this.asiento = 0;
        }
       
        public bool OCUPADO
        {
            get { return ocupado; }
            set { this.ocupado = value; }
        }
        public string USUARIO
        {
            get { return usuario; }
            set { this.usuario = value; }
        }
        public string RUTUSUARIO
        {
            get { return rutUsuario; }
            set { this.rutUsuario = value; }
        }
        public int ASIENTO
        {
            get { return asiento; }
            set { this.asiento = value; }
        }

        public bool ValidaRut()
        {
            string rut;
            bool rutverificado;
            //validadores
            if (this.rutUsuario == "")
            {
                System.Windows.Forms.MessageBox.Show("Debe ingresar todos los datos solicitados");
                rutverificado = false;
                return rutverificado;
            }
            else
            {
                //asignar variables

                rut = this.rutUsuario;
               
                //validar rut
                if (rut.Length < 10)
                {
                    while (rut.Length != 10)
                    {
                        rut = "0" + rut;
                    }
                }
                double suma = 0;
                double divisionDec = 0;
                int divisionEnt = 0;
                double valorDec = 0;
                double resta11 = 0;
                int digito = 0;
                string digitok = "";
                int[] constantes = { 3, 2, 7, 6, 5, 4, 3, 2 };
                int[] rutarreglo;
                rutarreglo = new int[8];
                for (int i = 0; i < 8; i++)
                {
                    rutarreglo[i] = Int32.Parse(rut[i].ToString());
                    suma = suma + (rutarreglo[i] * constantes[i]);
                }
                divisionDec = suma / 11;
                divisionEnt = (int)divisionDec;
                valorDec = divisionDec - divisionEnt;
                resta11 = 11 - (11 * (valorDec));
                digito = (int)Math.Round(resta11, 0);
                if (digito == 10)
                {
                    digitok = "k";
                }
                if (digito == 11)
                {
                    digito = 0;
                }
                if (Convert.ToString(digito) == Convert.ToString(rut[9]) || digitok == Convert.ToString(rut[9]))
                {
                    rutverificado = true;

                    return rutverificado;
                   
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("El rut es incorrecto");
                    rutverificado = false;

                    return rutverificado;

                }
            }
        }
    }
}
