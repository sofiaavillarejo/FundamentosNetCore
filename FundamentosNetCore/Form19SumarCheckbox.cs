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
    public partial class Form19SumarCheckbox : Form
    {
        List<CheckBox> checkboxes;
        int suma;
        public Form19SumarCheckbox()
        {
            InitializeComponent();
            this.checkboxes = new List<CheckBox>();

            foreach (CheckBox checkbox in this.panel1.Controls)
            {
                this.checkboxes.Add(checkbox);
                checkbox.CheckStateChanged += SumarCheckboxes;
            }

            GenerarNumeros();
        }
        void GenerarNumeros()
        {
            Random random = new Random();


            foreach (CheckBox checkbox in this.checkboxes)
            {
                int numero = random.Next(1, 99);
                checkbox.Text = numero.ToString();
            }
        }

        void SumarCheckboxes(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            int numero = int.Parse(checkbox.Text);
            if (checkbox.Checked)
            {
                this.suma += numero;
            }else
            {
                this.suma -= numero;
            }

            this.txtNumero.Text = suma.ToString();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            GenerarNumeros();
        }
    }
}
