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
    public partial class Form17ListDelegados : Form
    {
        //DECLARAMOS UNA VARIABLE CONTADOR
        int contador;
        List<Button> botones;
        public Form17ListDelegados()
        {
            InitializeComponent();
            //le damos el valor dentro del constructor para una buena praxis
            this.contador = 0;
            this.botones = new List<Button>();
            //this.button1.Click += BotonPulsado;
            //si almacenamos todos los objetos dentro de la colección, podemos hacer la acción delegada
            //con un foreach
            //this.botones.Add(this.button1);
            //this.botones.Add(this.button2);
            //this.botones.Add(this.button3);
            //this.botones.Add(this.button4);
            //this.botones.Add(this.button5);
            //this.botones.Add(this.button6);

            //CON LA COLECCIÓN CONTROLS PODREMOS RECORRER UN CONJUNTO DE OBJETOS Y RELLENAR DINÁMICAMENTE NUESTRAS COLECCIONES PROPIAS
            foreach (Control miControl in this.Controls)
            {
                //debemos preguntar por los botones
                if (miControl is Button)
                {
                    this.botones.Add((Button)miControl);
                }
            }
            foreach (Button boton in this.botones)
            {
                boton.Click += BotonPulsado;
            }
        }
        //AL PULSAR CUALQUIER BOTON, QUIEOR INCREMENTAR EL CONTADOR
        //quiero que cambie el color del boton pulsado
        void BotonPulsado (object sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = this.contador.ToString();
            //sender es el objeto que realiza la llamada
            Button miBoton = (Button)sender; //basicamente, accede al boton que se está pulsando
            miBoton.BackColor = Color.Yellow;
        }
    }
}
