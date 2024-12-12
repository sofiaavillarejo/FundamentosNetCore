﻿using System;
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
    public partial class Form07SumarNumeros : Form
    {
        public Form07SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtNumeros.Text;
            int suma = 0;
            for (int i = 0; i < textoNumeros.Length; i++)
            {
                //recuperamos cada caracter del texto numeros
                char caracter = textoNumeros[i];

                //convertir el caracter a numeros
                //esta conversion no vale porque lo que recuperamos es el valor ASCII del numero
                //int numero = caracter;

                int numero = int.Parse(caracter.ToString());
                //int numero = Convert.ToInt32(caracter.ToString());

                //vamos sumando cada numero al anterior
                suma += numero;
            }
            this.lblResultado.Text = "La suma es " + suma;
        }
    }
}
