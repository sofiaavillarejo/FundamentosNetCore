namespace FundamentosNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //solo escribimos aqui
            
            //new Object()
            this.txtNombre.Location = new Point(20, 10);
            

            //tipo primitivo
            this.txtNombre.Width = 220;
            this.txtNombre.Text = "Soy un string";
            
            //propiedad enumerada
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            
            //estructura
            this.btnPulsar.BackColor = Color.Fuchsia;

            //CONVERSIÓN AUTOMATICA
            //el valor no hacemos caso, nos referimos al tipo de dato -> short
            //short pequeño = 88;
            //int mayor = pequeño;

            //STRING A PRIMITIVO
            string textoNumero = "1234";
            int numero = int.Parse(textoNumero);
            double otro = double.Parse(textoNumero);

            //CASTING PRIMITIVOS 
            int mayor = 88;
            short pequeño = (short)mayor;

            //CONVERTIR CUALQUIER OBJETO A STRING
            string texto = mayor.ToString();
            texto = btnPulsar.ToString();
        }
    }
}
