using System;
using System.Collections;
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
    public partial class Form16ArrayList : Form
    {
        public Form16ArrayList()
        {
            InitializeComponent();
            //VAMOS A CREAR UNA COLECCIÓN NO TIPADA
            //Y ALMACENAR LOS BOTONES
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //añadimos el nuevo textbox a la coleccion
            coleccion.Add(this.textBox1);

            //SI INTENTAMOS ACCEDER A UN ELEMENTO DE LA COLECCIÓN Y A SUS PROPIEDADES
            //DEBEMOS HACER UN CASTING
            ((Button)coleccion[0]).BackColor = Color.Yellow;

            //MEDIANTE LA ABSTRACCIÓN, PODEMOS CONVERTIR Y RECORRER TODOS LOS OBJETOS DENTRO DE BUCLES DE REFERENCIA
            //foreach (Button boton in coleccion)
            //{
            //    boton.BackColor = Color.LightBlue;
            //}

            //AHORA TENEMOS BOTONES Y TEXTO EN LA COLECCION -> CLASE CONTROL PARA RECORRER
            foreach (Control control in coleccion)
            {
                control.BackColor = Color.Green;
                //LA CLASE TEXTBOX CONTIENE UN METODO Paste() -> pegar el contenido del portapapeles en el interior del control
                //DEBEMOS PREGUNTAR POR EL TIPO DE CONTROL
                if (control is TextBox)
                {
                    //casteamos el control porque es un textbox (hacer casting es convertir una clase a otra)
                    ((TextBox)control).Paste();
                }
            }

            //DECLARAMOS UNA COLECCION DE BUTTON
            List<Button> botones = new List<Button>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            //EL OBJETO ES RECONOCIBLE POR SU TIPADO T
            botones[0].BackColor = Color.AliceBlue;

            //TENEMOS ERRORES DE COMPILACION Y NO TENEMOS QUE EJECUTAR PARA VERLOS -> VENTAHA
            //botones.Add(this.textBox1);

            this.button1.Click += MetodoDelegado;
            this.button1.Click += MetodoDelegadooo;
        }

        private void MetodoDelegadooo(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void MetodoDelegado(object sender, EventArgs e)
        {

        }
    }
}
