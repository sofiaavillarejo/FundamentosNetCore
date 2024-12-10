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
    public partial class Form01SumarNumeros : Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //guardamos en una variable el numero escrito en la caja y
            //lo parseamos a integer para poder sumarlo
            int num1 = int.Parse(this.txtNumero1.Text);
            int num2 = int.Parse(this.txtNumero2.Text);
            int suma = num1 + num2;
            //guardamos en la etiqueta resultado la suma pasandola a string
            //para que se pueda escribir
            this.lblResultado.Text = suma.ToString();
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form01SumarNumeros_Load(object sender, EventArgs e)
        {

        }
    }
}
