using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROG2EVA2FranciscoArmijo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection objeto_conect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\basesLeones\BDDPROG2FranciscoArmijo.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable tabla_transito = new DataTable();

        string rut = "";
        string nombre = "";
        string clave = "";
        int nivel = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //validadores
            if (textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los datos solicitados");
            }
            else
            {
                //no es necesario validar rut en el primer ingreso ya que los rut ya estan en las tablas
                objeto_conect.Open();
                tabla_transito.Clear();
                SqlDataAdapter sentencia = new SqlDataAdapter("select * from PERFILESFranciscoArmijo where rut = '"+ textBox2.Text +"'", objeto_conect);
                sentencia.Fill(tabla_transito);
                if (tabla_transito.Rows.Count.Equals(0) )
                {
                    MessageBox.Show("El rut no existe", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (tabla_transito.Rows[0]["Clave"].ToString() == textBox1.Text)
                    {
                        MessageBox.Show("Su usuario y clave son correctos, puede ingresar", "Bienvenido ", MessageBoxButtons.OK);
                        nombre = tabla_transito.Rows[0]["Nombre"].ToString() + " " + tabla_transito.Rows[0]["ApPat"].ToString();
                        rut = tabla_transito.Rows[0]["Rut"].ToString();
                        clave = tabla_transito.Rows[0]["Clave"].ToString();
                        nivel = Convert.ToInt32(tabla_transito.Rows[0]["NIVEL"]);
                        ventana_venta vent = new ventana_venta(nombre, rut, clave, nivel);
                        vent.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales incorrectas", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                objeto_conect.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cantidad = this.textBox2.TextLength.ToString();
            var cantidad2 = Convert.ToInt32(cantidad);
            if (cantidad2 <= 7)
            {
                string cadena = "1234567890" + (char)8;

                if (!cadena.Contains(e.KeyChar))
                {

                    e.Handled = true;

                }
            }
            else
            {

                string cadena = "-Kk1234567890" + (char)8;

                if (!cadena.Contains(e.KeyChar))
                {

                    e.Handled = true;

                }
            }
        }
    }
}
