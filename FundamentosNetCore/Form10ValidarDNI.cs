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
    public partial class Form10ValidarDNI : Form
    {
        public Form10ValidarDNI()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string dni = this.txtDNI.Text;
            int longitudDni = dni.Length;
            if (longitudDni != 9)
            {
                MessageBox.Show("El DNI debe tener 9 caracteres");
            }
            else
            {
                string numerosDni = dni.Substring(0, 8);
                char letraDNI = dni[8];

                char[] tablaLetras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
                int resultado = int.Parse(numerosDni) % 23;
                char letraValida = tablaLetras[resultado];

                if (letraDNI == letraValida)
                {
                    MessageBox.Show("El DNI es válido.");
                }
                else
                {
                    MessageBox.Show($"El DNI no es válido. La letra correcta debería ser '{letraValida}'.");
                }
            }
        }
    }
}
