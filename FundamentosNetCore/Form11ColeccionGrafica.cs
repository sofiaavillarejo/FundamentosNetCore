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
    public partial class Form11ColeccionGrafica : Form
    {
        public Form11ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtTexto.Text;
            //añadimos el nuevo elemento
            this.lstElementos.Items.Add(elem);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //eliminamos el elemento seleccionado
            //pasamos a string el elemento porque es una coleccion de tipo objeto
            //string elementoSeleccionado = this.lstElementos.SelectedItem.ToString();
            //this.lstElementos.Items.Remove(elementoSeleccionado);

            //en vez de por elemento, vamos a eliminarlo por index que es mejor

            int indexSelect = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(indexSelect);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            //borramos todo
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //preguntamos si tenemos elementos seleccionados
            if (this.lstElementos.SelectedIndex != -1)
            {
                //si no escribo algo entre las comillas o simplemente las pongo, da error de int
                this.lblIndexSelect.Text = "Index seleccionado: "+ this.lstElementos.SelectedIndex;
                this.lblItemSelect.Text = "Item seleccionado: " + this.lstElementos.SelectedItem;
            }
        }
    }
}
