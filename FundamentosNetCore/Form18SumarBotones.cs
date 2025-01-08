using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form18SumarBotones : Form
    {
        List<Button> botones;
        int suma;
        public Form18SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();

            //ALMACENAMOS TODOS LOS CONTROLES DEL PANEL DENTRO DE NUESTRA COLECCION
            foreach (Button boton in this.panel1.Controls)
            {
                this.botones.Add(boton);
                //DELEGAMOS LA ACCION DE LOS BOTONES PARA QUE FUNCIONEN BIEN
                boton.Click += SumarNumeros;
            }

            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        void SumarNumeros(object sender, EventArgs e)
        {
            //CAPTURAMOS EL BTN que se clica
            Button boton = (Button)sender;
            //CAPTURAMOS EL NUMERO DEL BOTON
            int numero = int.Parse(boton.Text);
            //sumamos el numero a la suma
            this.suma += numero;
            this.txtNumero.Text = suma.ToString();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.txtNumero.Text = suma.ToString();
            //RECORREMOS TODOS LOS BOTONES DE MI COLECCIÓN
            foreach (Button boton in this.botones)
            {
                int numAleatorio = random.Next(1, 99);
                boton.Text = numAleatorio.ToString();
            }
        }
    }
}
