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
    public partial class Form06ValidarEmail : Form
    {
        public Form06ValidarEmail()
        {
            InitializeComponent();
        }

        private void btnValidarMail_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            
            //• Exista @
            if (!email.Contains('@'))
            {
                MessageBox.Show("El email debe contener un @.");
                return;
            }
            //• Ni @ al inicio ni al final
            if (email.StartsWith('@') || email.EndsWith('@'))
            {
                MessageBox.Show("El @ solo debe aparecer una vez antes del . dominio");
                return;
            }
            //• No exista más de una @
            if (email.Count(c => c == '@') != 1)
            {
                MessageBox.Show("El correo solo puede contener una '@'.");
                return;
            }
            //• Exista un punto
            if (!email.Contains('.'))
            {
                MessageBox.Show("El correo debe contener un . antes del dominio");
                return;
            }
            //• Exista un punto después de @
            if (email.LastIndexOf('.') == -1)
            {
                MessageBox.Show("El correo debe contener un . después del @");
                return;
            }

            string[] parteEmail = email.Split('.');
            //•Dominio de 2 a 4 caracteres(com, es, org, como)
            if (parteEmail[1].Length > 4 && parteEmail[1].Length < 2 || parteEmail[1].Length == 0)
            {
                MessageBox.Show("El dominio debe contener mínimo 2 caracteres y máximo 4");
                return;
            }

            this.lblResultado.Text = email;
          
        }
    }
}
