using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;

namespace FundamentosNetCore
{
    public partial class Form21Files : Form
    {
        private string Path { get; set; }
        private HelperFiles helper;

        public Form21Files()
        {
            InitializeComponent();
            this.helper = new HelperFiles();

            //cuando hablamos de rutas de ficheros, con caracteres especiales, (\)
            //tenemos dos posibilidades:

            //1. usar doble \\
            //this.Path = "C: \\carpeta\\file1.txt";

            //2. Indicar que el string será literal -> @
            //this.Path = @"C:\carpeta\file1.txt";
            this.Path = "file1.txt";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.Select();
            this.txtNombre.Focus();

        }
        public string GetNombresListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(','); //eliminamos la útlima coma
            return data;
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            //hemos importado System.IO
            //tenemos una clase FileInfo -> devuelve un file y podemos generar writer o reader sobre ella
            //FileInfo file = new FileInfo(this.Path);
            ////creamos el fichero, asegurandonos de que exista para que no de una excepción
            //using (TextWriter writer = file.CreateText())
            //{
            //    //recuperamos los nombres del lst
            //    string contenido = this.GetNombresListBox();
            //    //escribimos dentro del fichero
            //    await writer.WriteAsync(contenido);
            //    //tras escribir en cualquier fihcero, se DEBE aplicar el método Flush() -> liberar memoria
            //    await writer.FlushAsync(); //pone de forma fisica el contenido al fichero (lo escribe si o si)
            //    //cerrar el fichero
            //    writer.Close();
            //    MessageBox.Show("Datos almacenados");
            //}

            //EJERCICIO CON CLASES
            //esto ya no hace falta porque lo hemos metido arriba global -> HelperFiles helper = new HelperFiles();
            string data = this.GetNombresListBox();
            await HelperFiles.WriteFileAsync(this.Path, data);
            MessageBox.Show("Datos guardados");
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            //FileInfo file = new FileInfo(this.Path);
            //using (TextReader reader = file.OpenText())
            //{
            //    string contenido = await reader.ReadToEndAsync();
            //    //siempre se liberan los ficheros
            //    reader.Close();
            //    this.txtContenido.Text = contenido;
            //    this.RellenarListBox(contenido);
            //}

            //EJERCICIO CON CLASES
            string data = await HelperFiles.ReadFileAsync(this.Path);
            this.RellenarListBox(data);
            this.txtContenido.Text = data;
        }

        public void RellenarListBox(string nombres)
        {
            string[] data = nombres.Split(",");
            this.lstNombres.Items.Clear();
            foreach (string name in data)
            {
                this.lstNombres.Items.Add(name);
            }
        }
    }
}
