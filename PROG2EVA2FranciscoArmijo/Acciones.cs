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
using System.Data.SqlClient;

namespace PROG2EVA2FranciscoArmijo
{
    public partial class Acciones : Form
    {
        public Acciones()
        {
            InitializeComponent();
        }
        SqlConnection objeto_conect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\basesLeones\BDDPROG2FranciscoArmijo.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable tabla_transito = new DataTable();

        private void Acciones_Load(object sender, EventArgs e)
        {

        }

        private void botonTraspasar_Click(object sender, EventArgs e)
        {
            string[] lineas = File.ReadAllLines("C:\\TXTS\\VIGIAFRANCISCOARMIJO.txt");
            foreach (string indice in lineas)
            {
                string[] acciones = indice.Split(',');
                if (acciones.Length >1)
                {
                    objeto_conect.Open();
                    string sqlinsertar = "INSERT INTO ACCIONESFranciscoArmijo(Clave, InicioSesion, FinSesion,Accion,AccionF) values ('','" + acciones[1] + "','" + acciones[2] + "','" + acciones[3] + "','" + acciones[4] + "') ";
                    SqlDataAdapter sentencia = new SqlDataAdapter(sqlinsertar, objeto_conect);
                    tabla_transito.Clear();
                    sentencia.Fill(tabla_transito);
                    tabla_transito.Clear();
                    //Se buscan todos los valores de la tabla PERFILES
                    SqlDataAdapter sentencia2 = new SqlDataAdapter("select * from ACCIONESFranciscoArmijo", objeto_conect);
                    //Se llena la tabla temporal con los valores encontrados
                    sentencia2.Fill(tabla_transito);
                    dataAcciones.DataSource = tabla_transito;
                    objeto_conect.Close();
                }
                
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            string[] lineas = File.ReadAllLines("C:\\TXTS\\VIGIAFRANCISCOARMIJO.txt");
            foreach (string indice in lineas)
            {
                string[] acciones = indice.Split(',');
                if (acciones.Length > 1)
                {
                    if (acciones[0] == textRut.Text)
                    {
                        objeto_conect.Open();
                        string sqlinsertar = "INSERT INTO ACCIONESFranciscoArmijo(Clave, InicioSesion, FinSesion,Accion,AccionF) values ('','" + acciones[1] + "','" + acciones[2] + "','" + acciones[3] + "','" + acciones[4] + "') ";
                        SqlDataAdapter sentencia = new SqlDataAdapter(sqlinsertar, objeto_conect);
                        tabla_transito.Clear();
                        sentencia.Fill(tabla_transito);
                        tabla_transito.Clear();
                        //Se buscan todos los valores de la tabla PERFILES
                        SqlDataAdapter sentencia2 = new SqlDataAdapter("select * from ACCIONESFranciscoArmijo", objeto_conect);
                        //Se llena la tabla temporal con los valores encontrados
                        sentencia2.Fill(tabla_transito);
                        dataAcciones.DataSource = tabla_transito;
                        objeto_conect.Close();
                    }
                    
                }

            }
        }
    }
}
