using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anyo = int.Parse(this.txtAnyo.Text);
            int calculoMes;
            string[] semana = { "Sabado", "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };


            if (mes ==1)
            {
                mes = 13;
                anyo = anyo - 1;
            }
            if (mes == 2)
            {
                mes = 14;
                anyo--;
            }

            calculoMes = ((mes + 1) * 3) / 5;
            int anyo2 = anyo / 4;
            int anyo3 = anyo / 100;
            int anyo4 = anyo / 400;
            int paso5 = dia + (mes * 2) + anyo + calculoMes + anyo2 - anyo3 + anyo4 + 2;
            int op6 = paso5 / 7;
            int op7 = paso5 - (op6 * 7);

            this.lblResultado.Text = "Ese día era " + semana[op6];
        }
    }
}
