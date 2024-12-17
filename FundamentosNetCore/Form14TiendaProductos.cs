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
    public partial class Form14TiendaProductos : Form
    {
        public Form14TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex > 0)
            {
                int selectedIndex = this.lstAlmacen.SelectedIndex;

                string prodSelect = this.lstAlmacen.SelectedItem.ToString();

                this.lstAlmacen.Items.RemoveAt(selectedIndex);

                this.lstAlmacen.Items.Insert(selectedIndex - 1, prodSelect);

                this.lstAlmacen.SelectedIndex = selectedIndex - 1;
            }
            else
            {
                MessageBox.Show("No se puede subir más.");
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;
            if (!this.lstTienda.Items.Contains(producto))
            {
                this.lstTienda.Items.Add(producto);
                this.txtProducto.SelectAll();
                this.txtProducto.Focus();
            }
            else
            {
                MessageBox.Show("El producto ya existe.");
                for (int i = 0; i < this.lstTienda.Items.Count; i++)
                {
                    if (this.lstTienda.Items[i].ToString() == producto)
                    {
                        this.lstTienda.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int prodSeleccionados = this.lstTienda.SelectedIndices.Count;
            for (int i = prodSeleccionados - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            this.lstAlmacen.Items.AddRange(this.lstTienda.SelectedItems);
            int prodSeleccionados = this.lstTienda.SelectedIndices.Count;
            for (int i = prodSeleccionados - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                string producto = this.lstTienda.Items[index].ToString();

                this.lstAlmacen.Items.Add(producto);
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {

            //foreach (string producto in this.lstTienda.Items)
            //{
            //    this.lstAlmacen.Items.Add(producto);
            //}

            //EL METODO ADDRANGE EN LAS COLECCIONE PERMITE AGREGAR UN CONJUNTO A LA VEZ
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            this.lstTienda.Items.Clear();
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex < this.lstAlmacen.Items.Count - 1)
            {
                int selectedIndex = this.lstAlmacen.SelectedIndex;

                var selectedItem = this.lstAlmacen.SelectedItem;

                this.lstAlmacen.Items.RemoveAt(selectedIndex);

                this.lstAlmacen.Items.Insert(selectedIndex + 1, selectedItem);

                this.lstAlmacen.SelectedIndex = selectedIndex + 1;
            }
            else
            {
                MessageBox.Show("No se puede bajar más.");
            }
        }
    }
}
