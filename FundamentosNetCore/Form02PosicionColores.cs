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
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnCambiarPosicion_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(this.txtPosX.Text);
            int posY = int.Parse(this.txtPosY.Text);

            btnCambiarPosicion.Location = new Point(posX, posY);
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);
            if (rojo < 0 || rojo > 255)
            {
                MessageBox.Show("El valor rojo debe estar entre 0 y 255", "Alerta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            }
            //else if
            //{
            //    MessageBox.Show("El valor azul debe estar entre 0 y 255", "Alerta", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question)
            //}
            //else
            //{

            //}

            ActiveForm.BackColor =  Color.FromArgb(rojo, verde, azul);
        }
    }
}
