using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosNetCore
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Navidad";

            persona.Nacionalidad = Paises.Alemania;
            persona.Genero = TipoGenero.Femenino;

            //persona[0]

            //DIRECCION
            //crear la instancia de Direccion
            persona.Domicilio = new Direccion(); //la puede crear el form o la clase Persona
            persona.Domicilio.Calle = "Oficina principal de correos";
            persona.Domicilio.Ciudad = "Napapiiri, Finlandia";
            persona.Domicilio.CodigoPostal = 96930;

            //si ponemos edad negativa, saldra 0 al ejecutar por el if de las clase Persona.cs
            //persona.Edad = -25;

            //si ponemos edad positiva, saldrá la que es
            persona.Edad = 25;
            this.lstClases.Items.Add(persona.GetNombreCompleto());
            this.lstClases.Items.Add("Género: " + persona.Nacionalidad);
            this.lstClases.Items.Add("Dirección: " + persona.Domicilio.Calle + ", " + persona.Domicilio.Ciudad + ", " + persona.Domicilio.CodigoPostal);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //al clicar, se escribe un nuevo empleado que hereda las propiedades de la clase persona y las usa
            //Empleado empleado = new Empleado("Empleado", "Empleado");//esto lo recibe en los parametros del constructor persona y empleado
            
            //prueba tras usar el base()
            Empleado empleado = new Empleado();
            
            empleado.Nombre = "Empleado";
            empleado.Apellidos = "Empleado";

            //desde aqui, tambien podriamos cambiar el salario minimo de un empleado
            //Sin mebargo, una clase Form no deberia poder cambiarlo -> protected
            //empleado.SalarioMinimo = 4000;

            this.lstClases.Items.Add(empleado.GetNombreCompleto());
            this.lstClases.Items.Add("Salario empleado " + empleado.GetSalarioMinimo());
            this.lstClases.Items.Add("Vacaciones empleado " + empleado.GetDiasVacaciones());
            //creamos el director
            Director dir = new Director();
            dir.Nombre = "Director";
            dir.Apellidos = "Director";
            this.lstClases.Items.Add(dir.GetNombreCompleto());
            this.lstClases.Items.Add("Vacaciones director " + dir.GetDiasVacaciones());

            this.lstClases.Items.Add("Salario Director " + dir.GetSalarioMinimo());
        }
    }
}

//UNA CLASE SIEMPRE LEERÁ EL CONSTRUCTOR VACÍO DE LA CLASE QUE HEREDA (SI LO TIENE)