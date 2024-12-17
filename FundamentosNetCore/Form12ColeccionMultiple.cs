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
    public partial class Form12ColeccionMultiple : Form
    {
        public Form12ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = txtTexto.Text;
            this.lstElementos.Items.Add(elem);
            this.txtTexto.Focus();
            this.txtTexto.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index + ", ";
            }
            this.lblIndexSelect.Text = indices.Trim();
            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + ", ";
            }
            this.lblSeleccionados.Text = items.Trim(',');
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //HAY QUE ELIMINAR MULTIPLES ELEMENTOS DENTRO DE LA LISTA
            //ELIMINAREMOS MEDANTE SU INDEX DEBEMOS RECORRER LA COLECCIÓN SelectedIndices   
            //RECUPERAMOS CADA INDEX Y ELIMINAMOS CADA ITEM 
            //SIEMPRE QUE VAYAMOS A HACER CAMBIOS EN LA COLECCIÓN, USAR BUCLE FOR (FOREACH NO SE PUEDE)

            //for (int i = 0; i < this.lstElementos.SelectedIndices.Count; i++)
            //{
            //    int index = this.lstElementos.SelectedIndices[i];
            //    //ELIMINAMOS CADA ELEMENTO DE LA COLECCION
            //    this.lstElementos.Items.RemoveAt(index);
            //}

            //DEBIDO AL REPOSICIONAMIENTO DE LA COLECCION, SE BORRAN MAL LOS ELEMENTOS ASI QUE DEBEMOS
            //HACER EL BUCLE INVERSO PARA QUE SE BORREN LOS ELEMENTOS DESDE EL FINAL HASTA EL PRINCIO (PORQUE ASÍ NO AFECTA)
            int numSeleccionados = this.lstElementos.SelectedIndices.Count;
            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(index);
            }
        }
    }
}
