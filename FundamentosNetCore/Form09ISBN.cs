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
    public partial class Form09ISBN : Form
    {
        public Form09ISBN()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string textoIsbn = this.txtISBN.Text;
            int longitudTexto = textoIsbn.Length;

            if (longitudTexto != 10)
            {
                MessageBox.Show("El ISBN debe contener exactamente 10 dígitos.");
                return;
            }
            else
            {
                int resultado = 0;
                for (int i = 0; i < longitudTexto; i++)
                {
                    int numero = int.Parse(textoIsbn[i].ToString());

                    //se suma uno para que sea del 1 al 10, si solo pongo i (que es el indice), iría de 0 a 9
                    int op = numero * (i + 1);

                    resultado += op;
                }
                if (resultado % 11 == 0 )
                {
                    this.lblValidacion.Text = "El ISBN es correcto";
                } 
                else
                {
                    MessageBox.Show("El ISBN introducido no es correcto. Introduce uno válido, por favor.");
                }
            }

        }
    }
}
