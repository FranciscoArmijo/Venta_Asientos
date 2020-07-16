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
    public partial class PERFILES : Form
    {
        public PERFILES()
        {
            InitializeComponent();
        }
        //prueba
        SqlConnection objeto_conect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\basesLeones\BDDPROG2FranciscoArmijo.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable tabla_transito = new DataTable();

        private void cargardata()
        {
            objeto_conect.Open();
            tabla_transito.Clear();
            //Se buscan todos los valores de la tabla PERFILES
            SqlDataAdapter sentencia = new SqlDataAdapter("select * from PERFILESFranciscoArmijo ", objeto_conect);
            //Se llena la tabla temporal con los valores encontrados
            sentencia.Fill(tabla_transito);
            dataPerfiles.DataSource = tabla_transito;
            objeto_conect.Close();
        }

        private void limpiartext()
        {
            textNombre.Text = "";
            textPaterno.Text = "";
            textMaterno.Text = "";
            textRut.Text = "";
            textNivel.Text = "";
            textClave.Text = "";
        }

        private void PERFILES_Load(object sender, EventArgs e)
        {
            cargardata();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (textRut.Text == "" || textNombre.Text == "" || textPaterno.Text == "" || textMaterno.Text == "" || textNivel.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos solicitados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string rut = textRut.Text;
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
                    objeto_conect.Open();
                    string clave = textNombre.Text.Substring(0, 1) + textPaterno.Text.Substring(0, 1) + textMaterno.Text.Substring(0, 1) + textRut.Text;
                    string sqlinsertar = "insert into PERFILESFranciscoArmijo(Rut, Nombre, ApPat, ApMat, Clave, NIVEL) values ('" + textRut.Text + "', '" + textNombre.Text + "', '" + textPaterno.Text + "', '" + textMaterno.Text + "', '" + clave + "', " + textNivel.Text + ")";
                    SqlDataAdapter sentencia = new SqlDataAdapter(sqlinsertar, objeto_conect);
                    tabla_transito.Clear();
                    sentencia.Fill(tabla_transito);
                    tabla_transito.Clear();
                    //Se buscan todos los valores de la tabla PERFILES
                    SqlDataAdapter sentencia2 = new SqlDataAdapter("select * from PERFILESFranciscoArmijo", objeto_conect);
                    //Se llena la tabla temporal con los valores encontrados
                    sentencia2.Fill(tabla_transito);
                    dataPerfiles.DataSource = tabla_transito;
                    objeto_conect.Close();
                    limpiartext();
                }
                else
                {
                    MessageBox.Show("El rut es incorrecto", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if (textPaterno.Text == "" || textClave.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido paterno y clave para la busqueda", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textRut.Enabled = false;
                tabla_transito.Clear();
                objeto_conect.Open();
                SqlDataAdapter buscar = new SqlDataAdapter("select * from PERFILESFranciscoArmijo where ApPat like '%" + textPaterno.Text + "%' and Clave = '"+ textClave.Text+"'", objeto_conect);
                buscar.Fill(tabla_transito);
                //se llenan los textbox con los datos de las tablas
                dataPerfiles.DataSource = tabla_transito;
                textNombre.Text = tabla_transito.Rows[0]["Nombre"].ToString();
                textPaterno.Text = tabla_transito.Rows[0]["ApPat"].ToString();
                textMaterno.Text = tabla_transito.Rows[0]["ApMat"].ToString();
                textRut.Text = tabla_transito.Rows[0]["Rut"].ToString();
                textNivel.Text = tabla_transito.Rows[0]["NIVEL"].ToString();
                textClave.Text = tabla_transito.Rows[0]["Clave"].ToString();
                objeto_conect.Close();
            }
            
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            textRut.Enabled = true;
            tabla_transito.Clear();
            objeto_conect.Open();
            SqlDataAdapter eliminar = new SqlDataAdapter("DELETE from PERFILESFranciscoArmijo where Clave = '" + textClave.Text+ "'", objeto_conect);
            eliminar.Fill(tabla_transito);

            //Se buscan todos los valores de la tabla PERFILES
            SqlDataAdapter sentencia2 = new SqlDataAdapter("select * from PERFILESFranciscoArmijo", objeto_conect);
            //Se llena la tabla temporal con los valores encontrados
            sentencia2.Fill(tabla_transito);
            dataPerfiles.DataSource = tabla_transito;
            objeto_conect.Close();
            limpiartext();
        }

        private void botonAcciones_Click(object sender, EventArgs e)
        {
           
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            textRut.Enabled = true;
            tabla_transito.Clear();
            objeto_conect.Open();
            SqlDataAdapter update = new SqlDataAdapter("update PERFILESFranciscoArmijo set Rut = '" + textRut.Text + "', Nombre = '" + textNombre.Text + "', ApPat = '"+ textPaterno.Text+"', ApMat = '"+textMaterno.Text+"', NIVEL = "+ textNivel.Text+"where Clave ='"+textClave.Text+"'", objeto_conect);
            update.Fill(tabla_transito);
            objeto_conect.Close();
            cargardata();
            limpiartext();
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            limpiartext();
            textRut.Enabled = true;
        }

        private void textRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cantidad = this. textRut.TextLength.ToString();
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
