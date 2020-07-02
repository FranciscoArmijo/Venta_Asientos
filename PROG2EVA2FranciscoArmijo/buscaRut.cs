using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROG2EVA2FranciscoArmijo
{
    public partial class buscaRut : Form
    {
        public buscaRut()
        {
            InitializeComponent();
        }

        string rut = "";
        private void button1_Click(object sender, EventArgs e)
        {
            //validadores
            if (textBox2.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los datos solicitados");
            }
            else
            {
                //asignar variables

                rut = textBox2.Text;
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

                    string mensaje = "";
                    string[] lineas = File.ReadAllLines("C:\\TXTS\\VIGIAFRANCISCOARMIJO.txt");
                    foreach (string indice in lineas)
                    {
                        string[] busqueda = indice.Split(',');
                        if (busqueda[0].Equals(textBox2.Text))
                        {
                            mensaje += indice + "\n";
                        }
                        
                    }

                    MessageBox.Show(mensaje);

                    /*
                    StreamReader lector = new StreamReader("C:\\TXT\\VIGIAFRANCISCOARMIJO.txt");
                    string mensaje = "";
                    string linea = lector.ReadLine();
                    while (linea != null)
                    {
                        string[] busqueda = linea.Split(',');
                        if (busqueda[0].Equals(textBox2.Text))
                        {
                            mensaje = mensaje + linea + "\n";
                        }
                    }
                    MessageBox.Show(mensaje);
                    lector.Close();
                    */
                }
                else
                {
                    MessageBox.Show("El rut es incorrecto", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }
    }
}
