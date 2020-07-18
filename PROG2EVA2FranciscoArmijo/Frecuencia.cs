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
using System.Windows.Forms.DataVisualization.Charting;

namespace PROG2EVA2FranciscoArmijo
{
    public partial class Frecuencia : Form
    {
        public Frecuencia()
        {
            InitializeComponent();
        }
        //acciones
        //"Borra todas las reservas"
        //"Realiza reserva"
        //"Muestra todas las reservas"
        //"Inicio Sesión"
        SqlConnection objeto_conect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\basesLeones\BDDPROG2FranciscoArmijo.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable tabla_transito = new DataTable();
        int borrar = 0;
        int reservar = 0;
        int mostrar = 0;
        int inicio = 0;
        private void Frecuencia_Load(object sender, EventArgs e)
        {
            //se llama con una consulta la cantidad de veces que se repite cada accion
            objeto_conect.Open();
            DataSet dato = new DataSet();
            SqlDataAdapter sentencia = new SqlDataAdapter("select count(*) AS Cantidad from ACCIONESFranciscoArmijo where upper(Accion) = 'Inicio Sesión'; ", objeto_conect);
            SqlDataAdapter sentencia2 = new SqlDataAdapter("select count(*) AS Cantidad from ACCIONESFranciscoArmijo where upper(Accion) = 'Muestra todas las reservas'; ", objeto_conect);
            SqlDataAdapter sentencia3 = new SqlDataAdapter("select count(*) AS Cantidad from ACCIONESFranciscoArmijo where upper(Accion) = 'Realiza reserva'; ", objeto_conect);
            SqlDataAdapter sentencia4 = new SqlDataAdapter("select count(*) AS Cantidad from ACCIONESFranciscoArmijo where upper(Accion) = 'Borra todas las reservas'; ", objeto_conect);
            sentencia.Fill(dato);
            inicio = Convert.ToInt32(dato.Tables["Table"].Rows[0]["Cantidad"]);
            dato.Clear();
            sentencia2.Fill(dato);
            mostrar = Convert.ToInt32(dato.Tables["Table"].Rows[0]["Cantidad"]);
            dato.Clear();
            sentencia3.Fill(dato);
            reservar = Convert.ToInt32(dato.Tables["Table"].Rows[0]["Cantidad"]);
            dato.Clear();
            sentencia4.Fill(dato);
            borrar = Convert.ToInt32(dato.Tables["Table"].Rows[0]["Cantidad"]);
            objeto_conect.Close();

            string[] series = { "Inicio Sesión", "Muestra todas las reservas", "Realiza reserva", "Borra todas las reservas" };
            int[] puntos = {inicio, mostrar, reservar, borrar };
            chart1.Palette = ChartColorPalette.SeaGreen;
            //titulo del chart
            chart1.Titles.Add("Frecuencia de acciones");
            //el for recorre las series
            for (int i = 0; i<series.Length; i++)
            {
                //nombres
                Series serie = chart1.Series.Add(series[i]);
                //cantidades

                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }
    }
}
