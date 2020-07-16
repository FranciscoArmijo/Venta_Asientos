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
    public partial class ventana_venta : Form
    {
        public ventana_venta()
        {
            InitializeComponent();
        }
        //se crean lso aobjetos asientos
        asientoBus asiento1 = new asientoBus();
        asientoBus asiento2 = new asientoBus();
        asientoBus asiento3 = new asientoBus();
        asientoBus asiento4 = new asientoBus();
        asientoBus asiento5 = new asientoBus();
        asientoBus asiento6 = new asientoBus();
        asientoBus asiento7 = new asientoBus();
        asientoBus asiento8 = new asientoBus();
        asientoBus asiento9 = new asientoBus();
        asientoBus asiento10 = new asientoBus();
        asientoBus asiento11 = new asientoBus();
        asientoBus asiento12 = new asientoBus();
        asientoBus asiento13 = new asientoBus();
        asientoBus asiento14 = new asientoBus();
        asientoBus asiento15 = new asientoBus();
        asientoBus asiento16 = new asientoBus();
        asientoBus asiento17 = new asientoBus();
        asientoBus asiento18 = new asientoBus();
        asientoBus asiento19 = new asientoBus();
        asientoBus asiento20 = new asientoBus();
        asientoBus asiento21 = new asientoBus();

        


        string nombreVendedor;
        string rutVendedor;
        //se agregan dos nuevos parametros para el programa y se crean en el constructor
        string claveVendedor;
        int nivelVendedor;

        List<asientoBus> listanombres = new List<asientoBus>();

        CLASEEVALUA2FranciscoArmijo USUARIO = new CLASEEVALUA2FranciscoArmijo();

        List<CLASEEVALUA2FranciscoArmijo> log = new List<CLASEEVALUA2FranciscoArmijo>();

        //constructor
        public ventana_venta(string nombre, string rut, string clave, int nivel)
        {
            
            //se toman lso datos del formulario inicial
             InitializeComponent();
            nombreVendedor = nombre;
            rutVendedor = rut;
            claveVendedor = clave;
            nivelVendedor = nivel;
            labelVendedor.Text = nombreVendedor;
            USUARIO.CLAVE = claveVendedor;
            USUARIO.RUT = rutVendedor;
            USUARIO.DATEINICIO = DateTime.Now;
            USUARIO.ACCION = "Inicio Sesión";
            USUARIO.DATEACCION = DateTime.Now;
            log.Add(USUARIO);

        }

        private void ventana_venta_Load(object sender, EventArgs e)
        {
            if (nivelVendedor == 1)
            {
                botonPerfil.Enabled = true;
            }
            else
            {
                botonPerfil.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento1.OCUPADO)
            {
                pictureBox1.Image = Properties.Resources.VACIO;
                asiento1.OCUPADO = false;
                asiento1.USUARIO = "";
                asiento1.RUTUSUARIO = "";
                asiento1.ASIENTO = 0;
            }
            else
            {
                asiento1.RUTUSUARIO = textRut.Text;
                if (asiento1.ValidaRut())
                {
                    pictureBox1.Image = Properties.Resources.OCUPADO;
                    asiento1.OCUPADO = true;
                    asiento1.USUARIO = textPasajero.Text;
                    asiento1.ASIENTO = Convert.ToInt32(labelSilla1.Text.Substring(2));
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLASEEVALUA2FranciscoArmijo RESERVA = new CLASEEVALUA2FranciscoArmijo();
            //Agrega las acciones al objeto y lo gaurda en lista

            RESERVA.ACCION = "Realiza reserva";
            RESERVA.DATEACCION = DateTime.Now;
            log.Add(RESERVA);
            


            textPasajero.Text = "";
            textRut.Text = "";
            listanombres.Clear();
            //agregar apsajeros a la lista
            listanombres.Add(asiento1);
            listanombres.Add(asiento2);
            listanombres.Add(asiento3);
            listanombres.Add(asiento4);
            listanombres.Add(asiento5);
            listanombres.Add(asiento6);
            listanombres.Add(asiento7);
            listanombres.Add(asiento8);
            listanombres.Add(asiento9);
            listanombres.Add(asiento10);
            listanombres.Add(asiento11);
            listanombres.Add(asiento12);
            listanombres.Add(asiento13);
            listanombres.Add(asiento14);
            listanombres.Add(asiento15);
            listanombres.Add(asiento16);
            listanombres.Add(asiento17);
            listanombres.Add(asiento18);
            listanombres.Add(asiento19);
            listanombres.Add(asiento20);
            listanombres.Add(asiento21);
            //bloquear asientos usados
            if (asiento1.OCUPADO)
            {
                pictureBox1.Enabled = false;
                pictureBox1.BackColor = Color.PaleTurquoise;
            }
            if (asiento2.OCUPADO)
            {
                pictureBox2.Enabled = false;
                pictureBox2.BackColor = Color.PaleTurquoise;
            }
            if (asiento3.OCUPADO)
            {
                pictureBox3.Enabled = false;
                pictureBox3.BackColor = Color.PaleTurquoise;
            }
            if (asiento4.OCUPADO)
            {
                pictureBox6.Enabled = false;
                pictureBox6.BackColor = Color.PaleTurquoise;
            }
            if (asiento5.OCUPADO)
            {
                pictureBox5.Enabled = false;
                pictureBox5.BackColor = Color.PaleTurquoise;
            }
            if (asiento6.OCUPADO)
            {
                pictureBox4.Enabled = false;
                pictureBox4.BackColor = Color.PaleTurquoise;
            }
            if (asiento7.OCUPADO)
            {
                pictureBox9.Enabled = false;
                pictureBox9.BackColor = Color.PaleTurquoise;
            }
            if (asiento8.OCUPADO)
            {
                pictureBox8.Enabled = false;
                pictureBox8.BackColor = Color.PaleTurquoise;
            }
            if (asiento9.OCUPADO)
            {
                pictureBox7.Enabled = false;
                pictureBox7.BackColor = Color.PaleTurquoise;
            }
            if (asiento10.OCUPADO)
            {
                pictureBox12.Enabled = false;
                pictureBox12.BackColor = Color.PaleTurquoise;
            }
            if (asiento11.OCUPADO)
            {
                pictureBox11.Enabled = false;
                pictureBox11.BackColor = Color.PaleTurquoise;
            }
            if (asiento12.OCUPADO)
            {
                pictureBox10.Enabled = false;
                pictureBox10.BackColor = Color.PaleTurquoise;
            }
            if (asiento13.OCUPADO)
            {
                pictureBox15.Enabled = false;
                pictureBox15.BackColor = Color.PaleTurquoise;
            }
            if (asiento14.OCUPADO)
            {
                pictureBox14.Enabled = false;
                pictureBox14.BackColor = Color.PaleTurquoise;
            }
            if (asiento15.OCUPADO)
            {
                pictureBox13.Enabled = false;
                pictureBox13.BackColor = Color.PaleTurquoise;
            }
            if (asiento16.OCUPADO)
            {
                pictureBox18.Enabled = false;
                pictureBox18.BackColor = Color.PaleTurquoise;
            }
            if (asiento17.OCUPADO)
            {
                pictureBox17.Enabled = false;
                pictureBox17.BackColor = Color.PaleTurquoise;
            }
            if (asiento18.OCUPADO)
            {
                pictureBox16.Enabled = false;
                pictureBox16.BackColor = Color.PaleTurquoise;
            }
            if (asiento19.OCUPADO)
            {
                pictureBox21.Enabled = false;
                pictureBox21.BackColor = Color.PaleTurquoise;
            }
            if (asiento20.OCUPADO)
            {
                pictureBox20.Enabled = false;
                pictureBox20.BackColor = Color.PaleTurquoise;
            }
            if (asiento21.OCUPADO)
            {
                pictureBox19.Enabled = false;
                pictureBox19.BackColor = Color.PaleTurquoise;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento2.OCUPADO)
            {
                pictureBox2.Image = Properties.Resources.VACIO;
                asiento2.OCUPADO = false;
                asiento2.USUARIO = "";
                asiento2.RUTUSUARIO = "";
                asiento2.ASIENTO = 0;
            }
            else
            {
                asiento2.RUTUSUARIO = textRut.Text;
                if (asiento2.ValidaRut())
                {
                    pictureBox2.Image = Properties.Resources.OCUPADO;
                    asiento2.OCUPADO = true;
                    asiento2.USUARIO = textPasajero.Text;
                    asiento2.ASIENTO = Convert.ToInt32(labelSilla2.Text.Substring(2));
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento3.OCUPADO)
            {
                pictureBox3.Image = Properties.Resources.VACIO;
                asiento3.OCUPADO = false;
                asiento3.USUARIO = "";
                asiento3.RUTUSUARIO = "";
                asiento3.ASIENTO = 0;
            }
            else
            {
                asiento3.RUTUSUARIO = textRut.Text;
                if (asiento3.ValidaRut())
                {
                    pictureBox3.Image = Properties.Resources.OCUPADO;
                    asiento3.OCUPADO = true;
                    asiento3.USUARIO = textPasajero.Text;
                    asiento3.ASIENTO = Convert.ToInt32(labelSilla3.Text.Substring(2));
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento4.OCUPADO)
            {
                pictureBox6.Image = Properties.Resources.VACIO;
                asiento4.OCUPADO = false;
                asiento4.USUARIO = "";
                asiento4.RUTUSUARIO = "";
                asiento4.ASIENTO = 0;
            }
            else
            {
                asiento4.RUTUSUARIO = textRut.Text;
                if (asiento4.ValidaRut())
                {
                    pictureBox6.Image = Properties.Resources.OCUPADO;
                    asiento4.OCUPADO = true;
                    asiento4.USUARIO = textPasajero.Text;
                    asiento4.ASIENTO = Convert.ToInt32(labelSilla4.Text.Substring(2));
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento5.OCUPADO)
            {
                pictureBox5.Image = Properties.Resources.VACIO;
                asiento5.OCUPADO = false;
                asiento5.USUARIO = "";
                asiento5.RUTUSUARIO = "";
                asiento5.ASIENTO = 0;
            }
            else
            {
                asiento5.RUTUSUARIO = textRut.Text;
                if (asiento5.ValidaRut())
                {
                    pictureBox5.Image = Properties.Resources.OCUPADO;
                    asiento5.OCUPADO = true;
                    asiento5.USUARIO = textPasajero.Text;
                    asiento5.ASIENTO = Convert.ToInt32(labelSilla5.Text.Substring(2));
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento6.OCUPADO)
            {
                pictureBox4.Image = Properties.Resources.VACIO;
                asiento6.OCUPADO = false;
                asiento6.USUARIO = "";
                asiento6.RUTUSUARIO = "";
                asiento6.ASIENTO = 0;
            }
            else
            {
                asiento6.RUTUSUARIO = textRut.Text;
                if (asiento6.ValidaRut())
                {
                    pictureBox4.Image = Properties.Resources.OCUPADO;
                    asiento6.OCUPADO = true;
                    asiento6.USUARIO = textPasajero.Text;
                    asiento6.ASIENTO = Convert.ToInt32(labelSilla6.Text.Substring(2));
                }
            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento7.OCUPADO)
            {
                pictureBox9.Image = Properties.Resources.VACIO;
                asiento7.OCUPADO = false;
                asiento7.USUARIO = "";
                asiento7.RUTUSUARIO = "";
                asiento7.ASIENTO = 0;
            }
            else
            {
                asiento7.RUTUSUARIO = textRut.Text;
                if (asiento7.ValidaRut())
                {
                    pictureBox9.Image = Properties.Resources.OCUPADO;
                    asiento7.OCUPADO = true;
                    asiento7.USUARIO = textPasajero.Text;
                    asiento7.ASIENTO = Convert.ToInt32(labelSilla7.Text.Substring(2));
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento8.OCUPADO)
            {
                pictureBox8.Image = Properties.Resources.VACIO;
                asiento8.OCUPADO = false;
                asiento8.USUARIO = "";
                asiento8.RUTUSUARIO = "";
                asiento8.ASIENTO = 0;
            }
            else
            {
                asiento8.RUTUSUARIO = textRut.Text;
                if (asiento8.ValidaRut())
                {
                    pictureBox8.Image = Properties.Resources.OCUPADO;
                    asiento8.OCUPADO = true;
                    asiento8.USUARIO = textPasajero.Text;
                    asiento8.ASIENTO = Convert.ToInt32(labelSilla8.Text.Substring(2));
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento9.OCUPADO)
            {
                pictureBox7.Image = Properties.Resources.VACIO;
                asiento9.OCUPADO = false;
                asiento9.USUARIO = "";
                asiento9.RUTUSUARIO = "";
                asiento9.ASIENTO = 0;
            }
            else
            {
                asiento9.RUTUSUARIO = textRut.Text;
                if (asiento9.ValidaRut())
                {
                    pictureBox7.Image = Properties.Resources.OCUPADO;
                    asiento9.OCUPADO = true;
                    asiento9.USUARIO = textPasajero.Text;
                    asiento9.ASIENTO = Convert.ToInt32(labelSilla9.Text.Substring(2));
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento10.OCUPADO)
            {
                pictureBox12.Image = Properties.Resources.VACIO;
                asiento10.OCUPADO = false;
                asiento10.USUARIO = "";
                asiento10.RUTUSUARIO = "";
                asiento10.ASIENTO = 0;
            }
            else
            {
                asiento10.RUTUSUARIO = textRut.Text;
                if (asiento10.ValidaRut())
                {
                    pictureBox12.Image = Properties.Resources.OCUPADO;
                    asiento10.OCUPADO = true;
                    asiento10.USUARIO = textPasajero.Text;
                    asiento10.ASIENTO = Convert.ToInt32(labelSilla10.Text.Substring(2));
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento11.OCUPADO)
            {
                pictureBox11.Image = Properties.Resources.VACIO;
                asiento11.OCUPADO = false;
                asiento11.USUARIO = "";
                asiento11.RUTUSUARIO = "";
                asiento11.ASIENTO = 0;
            }
            else
            {
                asiento11.RUTUSUARIO = textRut.Text;
                if (asiento11.ValidaRut())
                {
                    pictureBox11.Image = Properties.Resources.OCUPADO;
                    asiento11.OCUPADO = true;
                    asiento11.USUARIO = textPasajero.Text;
                    asiento11.ASIENTO = Convert.ToInt32(labelSilla11.Text.Substring(2));
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento12.OCUPADO)
            {
                pictureBox10.Image = Properties.Resources.VACIO;
                asiento12.OCUPADO = false;
                asiento12.USUARIO = "";
                asiento12.RUTUSUARIO = "";
                asiento12.ASIENTO = 0;
            }
            else
            {
                asiento12.RUTUSUARIO = textRut.Text;
                if (asiento12.ValidaRut())
                {
                    pictureBox10.Image = Properties.Resources.OCUPADO;
                    asiento12.OCUPADO = true;
                    asiento12.USUARIO = textPasajero.Text;
                    asiento12.ASIENTO = Convert.ToInt32(labelSilla12.Text.Substring(2));
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento13.OCUPADO)
            {
                pictureBox15.Image = Properties.Resources.VACIO;
                asiento13.OCUPADO = false;
                asiento13.USUARIO = "";
                asiento13.RUTUSUARIO = "";
                asiento13.ASIENTO = 0;
            }
            else
            {
                asiento13.RUTUSUARIO = textRut.Text;
                if (asiento13.ValidaRut())
                {
                    pictureBox15.Image = Properties.Resources.OCUPADO;
                    asiento13.OCUPADO = true;
                    asiento13.USUARIO = textPasajero.Text;
                    asiento13.ASIENTO = Convert.ToInt32(labelSilla13.Text.Substring(2));
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento14.OCUPADO)
            {
                pictureBox14.Image = Properties.Resources.VACIO;
                asiento14.OCUPADO = false;
                asiento14.USUARIO = "";
                asiento14.RUTUSUARIO = "";
                asiento14.ASIENTO = 0;
            }
            else
            {
                asiento14.RUTUSUARIO = textRut.Text;
                if (asiento14.ValidaRut())
                {
                    pictureBox14.Image = Properties.Resources.OCUPADO;
                    asiento14.OCUPADO = true;
                    asiento14.USUARIO = textPasajero.Text;
                    asiento14.ASIENTO = Convert.ToInt32(labelSilla14.Text.Substring(2));
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento15.OCUPADO)
            {
                pictureBox13.Image = Properties.Resources.VACIO;
                asiento15.OCUPADO = false;
                asiento15.USUARIO = "";
                asiento15.RUTUSUARIO = "";
                asiento15.ASIENTO = 0;
            }
            else
            {
                asiento15.RUTUSUARIO = textRut.Text;
                if (asiento15.ValidaRut())
                {
                    pictureBox13.Image = Properties.Resources.OCUPADO;
                    asiento15.OCUPADO = true;
                    asiento15.USUARIO = textPasajero.Text;
                    asiento15.ASIENTO = Convert.ToInt32(labelSilla15.Text.Substring(2));
                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento16.OCUPADO)
            {
                pictureBox18.Image = Properties.Resources.VACIO;
                asiento16.OCUPADO = false;
                asiento16.USUARIO = "";
                asiento16.RUTUSUARIO = "";
                asiento16.ASIENTO = 0;
            }
            else
            {
                asiento16.RUTUSUARIO = textRut.Text;
                if (asiento16.ValidaRut())
                {
                    pictureBox18.Image = Properties.Resources.OCUPADO;
                    asiento16.OCUPADO = true;
                    asiento16.USUARIO = textPasajero.Text;
                    asiento16.ASIENTO = Convert.ToInt32(labelSilla16.Text.Substring(2));
                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento17.OCUPADO)
            {
                pictureBox17.Image = Properties.Resources.VACIO;
                asiento17.OCUPADO = false;
                asiento17.USUARIO = "";
                asiento17.RUTUSUARIO = "";
                asiento17.ASIENTO = 0;
            }
            else
            {
                asiento17.RUTUSUARIO = textRut.Text;
                if (asiento17.ValidaRut())
                {
                    pictureBox17.Image = Properties.Resources.OCUPADO;
                    asiento17.OCUPADO = true;
                    asiento17.USUARIO = textPasajero.Text;
                    asiento17.ASIENTO = Convert.ToInt32(labelSilla17.Text.Substring(2));
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento18.OCUPADO)
            {
                pictureBox16.Image = Properties.Resources.VACIO;
                asiento18.OCUPADO = false;
                asiento18.USUARIO = "";
                asiento18.RUTUSUARIO = "";
                asiento18.ASIENTO = 0;
            }
            else
            {
                asiento18.RUTUSUARIO = textRut.Text;
                if (asiento18.ValidaRut())
                {
                    pictureBox16.Image = Properties.Resources.OCUPADO;
                    asiento18.OCUPADO = true;
                    asiento18.USUARIO = textPasajero.Text;
                    asiento18.ASIENTO = Convert.ToInt32(labelSilla18.Text.Substring(2));
                }
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento19.OCUPADO)
            {
                pictureBox21.Image = Properties.Resources.VACIO;
                asiento19.OCUPADO = false;
                asiento19.USUARIO = "";
                asiento19.RUTUSUARIO = "";
                asiento19.ASIENTO = 0;
            }
            else
            {
                asiento19.RUTUSUARIO = textRut.Text;
                if (asiento19.ValidaRut())
                {
                    pictureBox21.Image = Properties.Resources.OCUPADO;
                    asiento19.OCUPADO = true;
                    asiento19.USUARIO = textPasajero.Text;
                    asiento19.ASIENTO = Convert.ToInt32(labelSilla19.Text.Substring(2));
                }
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento20.OCUPADO)
            {
                pictureBox20.Image = Properties.Resources.VACIO;
                asiento20.OCUPADO = false;
                asiento20.USUARIO = "";
                asiento20.RUTUSUARIO = "";
                asiento20.ASIENTO = 0;
            }
            else
            {
                asiento20.RUTUSUARIO = textRut.Text;
                if (asiento20.ValidaRut())
                {
                    pictureBox20.Image = Properties.Resources.OCUPADO;
                    asiento20.OCUPADO = true;
                    asiento20.USUARIO = textPasajero.Text;
                    asiento20.ASIENTO = Convert.ToInt32(labelSilla20.Text.Substring(2));
                }
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            //se asignan valores a los objetos asientos
            if (asiento21.OCUPADO)
            {
                pictureBox19.Image = Properties.Resources.VACIO;
                asiento21.OCUPADO = false;
                asiento21.USUARIO = "";
                asiento21.RUTUSUARIO = "";
                asiento21.ASIENTO = 0;
            }
            else
            {
                asiento21.RUTUSUARIO = textRut.Text;
                if (asiento21.ValidaRut())
                {
                    pictureBox19.Image = Properties.Resources.OCUPADO;
                    asiento21.OCUPADO = true;
                    asiento21.USUARIO = textPasajero.Text;
                    asiento21.ASIENTO = Convert.ToInt32(labelSilla21.Text.Substring(2));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CLASEEVALUA2FranciscoArmijo MOSTRAR = new CLASEEVALUA2FranciscoArmijo();
            MOSTRAR.ACCION = "Muestra todas las reservas";
            MOSTRAR.DATEACCION = DateTime.Now;
            log.Add(MOSTRAR);
            

            // recorre lista y guarda los atributos en un string para msotrarlos
            string mensaje = "";
            foreach(asientoBus indice in listanombres)
            {
                mensaje += "Nombre: " + indice.USUARIO + " Rut: " + indice.RUTUSUARIO + " Asiento: " + indice.ASIENTO +"\n";
            }
            labelPasajeros.Text = mensaje;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLASEEVALUA2FranciscoArmijo LIMPIAR = new CLASEEVALUA2FranciscoArmijo();
            LIMPIAR.ACCION = "Borra todas las reservas";
            LIMPIAR.DATEACCION = DateTime.Now;
            log.Add(LIMPIAR);
            
            

            //vuelte todos los parametros de los objetos a su valor por defecto
            labelPasajeros.Text = "";
            listanombres.Clear();
            pictureBox1.Image = Properties.Resources.VACIO;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Enabled = true;
            asiento1.reiniciar();

            pictureBox2.Image = Properties.Resources.VACIO;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Enabled = true;
            asiento2.reiniciar();

            listanombres.Clear();
            pictureBox3.Image = Properties.Resources.VACIO;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Enabled = true;
            asiento3.reiniciar();

            listanombres.Clear();
            pictureBox4.Image = Properties.Resources.VACIO;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Enabled = true;
            asiento4.reiniciar();

            listanombres.Clear();
            pictureBox5.Image = Properties.Resources.VACIO;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Enabled = true;
            asiento5.reiniciar();

            listanombres.Clear();
            pictureBox6.Image = Properties.Resources.VACIO;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Enabled = true;
            asiento6.reiniciar();

            listanombres.Clear();
            pictureBox7.Image = Properties.Resources.VACIO;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Enabled = true;
            asiento7.reiniciar();

            listanombres.Clear();
            pictureBox8.Image = Properties.Resources.VACIO;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.Enabled = true;
            asiento8.reiniciar();

            listanombres.Clear();
            pictureBox9.Image = Properties.Resources.VACIO;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.Enabled = true;
            asiento9.reiniciar();

            listanombres.Clear();
            pictureBox10.Image = Properties.Resources.VACIO;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.Enabled = true;
            asiento10.reiniciar();

            listanombres.Clear();
            pictureBox11.Image = Properties.Resources.VACIO;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox11.Enabled = true;
            asiento11.reiniciar();

            listanombres.Clear();
            pictureBox12.Image = Properties.Resources.VACIO;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox12.Enabled = true;
            asiento12.reiniciar();

            listanombres.Clear();
            pictureBox13.Image = Properties.Resources.VACIO;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox13.Enabled = true;
            asiento13.reiniciar();

            listanombres.Clear();
            pictureBox14.Image = Properties.Resources.VACIO;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox14.Enabled = true;
            asiento14.reiniciar();

            listanombres.Clear();
            pictureBox15.Image = Properties.Resources.VACIO;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox15.Enabled = true;
            asiento15.reiniciar();

            listanombres.Clear();
            pictureBox16.Image = Properties.Resources.VACIO;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox16.Enabled = true;
            asiento16.reiniciar();

            listanombres.Clear();
            pictureBox17.Image = Properties.Resources.VACIO;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox17.Enabled = true;
            asiento17.reiniciar();

            listanombres.Clear();
            pictureBox18.Image = Properties.Resources.VACIO;
            pictureBox18.BackColor = Color.Transparent;
            pictureBox18.Enabled = true;
            asiento18.reiniciar();

            listanombres.Clear();
            pictureBox19.Image = Properties.Resources.VACIO;
            pictureBox19.BackColor = Color.Transparent;
            pictureBox19.Enabled = true;
            asiento19.reiniciar();

            listanombres.Clear();
            pictureBox20.Image = Properties.Resources.VACIO;
            pictureBox20.BackColor = Color.Transparent;
            pictureBox20.Enabled = true;
            asiento20.reiniciar();

            listanombres.Clear();
            pictureBox21.Image = Properties.Resources.VACIO;
            pictureBox21.BackColor = Color.Transparent;
            pictureBox21.Enabled = true;
            asiento21.reiniciar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            USUARIO.DATEFIN = DateTime.Now;

            StreamWriter escritor = File.AppendText("C:\\TXTS\\VIGIAFRANCISCOARMIJO.txt");

            foreach (CLASEEVALUA2FranciscoArmijo indice in log)
            {
                //se llama al metodo writeline y se actualiza si este existe
                //
                escritor.WriteLine(USUARIO.CLAVE + "," + USUARIO.DATEINICIO + "," + USUARIO.DATEFIN + "," + indice.ACCION + "," + indice.DATEACCION ); 
            }
            escritor.Close();

            Form1 abrir = new Form1();
            abrir.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            string[] lineas = File.ReadAllLines("C:\\TXTS\\VIGIAFRANCISCOARMIJO.txt");
            foreach (string indice in lineas)
            {
                mensaje += indice + "\n";
            }
            MessageBox.Show(mensaje);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buscaRut buscar = new buscaRut();
            buscar.Show();
        }
        private void botonPerfil_Click(object sender, EventArgs e)
        {
            if (botonPerfil.Enabled == false)
            {
                MessageBox.Show("Este boton es activo solo para usiarios nivel 1", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PERFILES perf = new PERFILES();
                perf.Show();
            }
        }

        private void botonAcciones_Click(object sender, EventArgs e)
        {
            Acciones aci = new Acciones(nombreVendedor, rutVendedor, nivelVendedor, claveVendedor);
            aci.Show();
        }
    }
}
