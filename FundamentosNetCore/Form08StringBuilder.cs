using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertirString_Click(object sender, EventArgs e)
        {
            //si no me reconociese la clase (using), usamos alt + enter y se agrega
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtTexto.Text;
            int longitud = cadena.Length;

            //inicia el proceso del cronómetro antes del bucle (analiza el tiempo)
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                //recuperamos la última letra
                char letra = cadena[longitud - 1];
                //eliminamos la última letra -> accediento a la última letra e indicamos cuantos caracteres a borrar (1)
                cadena = cadena.Remove(longitud - 1, 1);
                //insertamos la letra en la posición del bucle
                cadena = cadena.Insert(i, letra.ToString());
            }
            //detenemos el crono
            krono.Stop();

            // el objeto krono contiene una serie de propiedades para saber el tiempo que ha pasado
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds + ", Milisegundos: " + krono.Elapsed.Milliseconds;

            //pintar en la caja el resultado invertido
            this.txtTexto.Text = cadena;
        }

        private void btnInvertirStringBuilder_Click(object sender, EventArgs e)
        {
            //StringBuilder se usa para grandes cantidades de texto!
            Stopwatch krono = new Stopwatch();
            StringBuilder cadena = new StringBuilder();
            //para añadir un texto a StringBuilder
            cadena.Append(this.txtTexto.Text);
            int longitud = cadena.Length;
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                char letra = cadena[longitud - 1];
                cadena = cadena.Remove(longitud - 1, 1);
                cadena = cadena.Insert(i, letra);
            }
            krono.Stop();

            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds + ", Milisegundos: " + krono.Elapsed.Milliseconds;

            this.txtTexto.Text = cadena.ToString();
        }
    }
}
