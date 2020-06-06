using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG2EVA2FranciscoArmijo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string rut = "";
        string nombre = "";
        bool rutverificado = false;
        private void button1_Click(object sender, EventArgs e)
        {
            //validadores
            if (textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los datos solicitados");
            }
            else
            {
                //asignar variables
                
                rut = textBox2.Text;
                nombre = textBox1.Text;
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
                    MessageBox.Show("El rut es correcto, puede ingresar", "Bienvenido ", MessageBoxButtons.OK);
                    ventana_venta newventana = new ventana_venta(nombre, rut);
                    newventana.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El rut es incorrecto", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rutverificado = false;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
