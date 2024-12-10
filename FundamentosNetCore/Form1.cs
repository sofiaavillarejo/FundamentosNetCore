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
        }
    }
}
