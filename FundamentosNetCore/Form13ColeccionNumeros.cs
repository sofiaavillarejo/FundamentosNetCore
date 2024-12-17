using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FundamentosNetCore
{
    public partial class Form13ColeccionNumeros : Form
    {
        public Form13ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i <= 10; i++)
            {
                int randomNumber = random.Next(1, 100);
                this.lstNumeros.Items.Add(randomNumber);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int sumaTotal = 0;
            int sumaTotalPares = 0;
            int sumaTotalImpares = 0;

            foreach (int num in this.lstNumeros.Items)
            {
                sumaTotal += num;

                if (num % 2 == 0)
                {
                    sumaTotalPares += num; 
                } else
                {
                    sumaTotalImpares += num;
                }
            }
            this.txtSuma.Text = sumaTotal.ToString();
            this.txtPares.Text = sumaTotalPares.ToString();
            this.txtImpares.Text = sumaTotalImpares.ToString();

        }
    }
}
