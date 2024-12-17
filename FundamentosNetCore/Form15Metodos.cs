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
    public partial class Form15Metodos : Form
    {
        public Form15Metodos()
        {
            InitializeComponent();
        }

        //RECIBIMOS UN NUMERO WRAPPER POR VALOR
        void GetDobleValor(int num)
        {
            num = num * 2;
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.GetDobleValor(num);
            this.lblResultado.Text = num.ToString();
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.LightGreen;
        }
        private void btnObjetoRef_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleRef);
            this.CambiarColor(this.btnDobleValor);
        }

        //Realmente, nunca usariamos este metodo como variable referencia se haria como el siguiente
        void GetDobleRef(ref int num)
        {
            num = num * 2;
        }

        int GetDoble(int num)
        {
            return num * 2;
        }

        private void btnDobleRef_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            numero = this.GetDoble(numero);
            //las dos variables apuntan al mismo espacio de memoria.
            //this.GetDobleRef(ref numero);
            this.lblResultado.Text = numero.ToString();
        }

        private void Form15Metodos_FormClosed(object sender, FormClosedEventArgs e)
        {
            //e.
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + " Y: " + e.Y;
        }
        //al presionar la tecla
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //COMO NO PODEMOS ELIMINAR, DEBEMOS TAMBIEN ADMITIR
            //LA TECLA SE BORRAR (TENEMOS UN CHAR), DEBEMOS SABER
            // QUE TECLA TRADUCIDA A CHAR CORRESPONDE CON LA DE BORRAR
            //EXISTE UNA ENUMERACION LLAMADA Keys QUE NOS OFRECE LOS 
            //CODIGOS ASCII DE TODAS LAS TECLAS
            char teclaBorrar = (char)Keys.Back;

            if (char.IsDigit(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;

            if (char.IsLetter(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
