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
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            //AL INICIAR LA CLASE (CONSTRUCTOR), ESCRIBIREMOS LA FECHA ACTUAL
            this.txtFecha.Text = DateTime.Now.ToString();
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFecha.Text);

            //CONTROLAMOS LA ACCION SEGÚN EL RDB SELECCIONADO
            if (this.rdbDia.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            }
            else if (this.rdbMes.Checked == true)
            {
                fecha = fecha.AddMonths(incremento);
            }
            else
            {
                fecha = fecha.AddYears(incremento);
            }

            this.txtNuevaFecha.Text = fecha.ToString();
        }

        private void chkCambiarFormato_CheckedChanged(object sender, EventArgs e)
        {
            //RECUPERAMOS LA FECHA DE LA CAJA
            DateTime fecha = DateTime.Parse(this.txtFecha.Text);
            if (this.chkCambiarFormato.Checked == true)
            {
                this.txtFecha.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtFecha.Text = fecha.ToShortDateString();
            }
        }
    }
}
