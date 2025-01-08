using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        //ahora, el Empleado puede cambiar su propiedad, el director tambien y  el formulario NO
        protected int SalarioMinimo { get; set; }
        public Empleado() { 
            //:base("Nombre", "Apellidos") { //con esto, el empleado por defecto lea el constructor de la clase con parámetros y evitamos que lea el vacío. 
            //CNO ESTO, VEMOS QUE UN CONSTRUCTOR NO SUSTITUYE A OTRO.
            //Para construir un empleado, primer se debe construir persona.
            Debug.WriteLine("Constructor EMPLEADO vacío");
            this.SalarioMinimo = 1400;
        }
    public Empleado(string nombre, string apellidos)
        :base(nombre, apellidos)//llamo al constructor con nombre y apellidos porque sino da fallo
        {
            Debug.WriteLine("Constructor PERSONA 2 parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
    public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
    public virtual int GetDiasVacaciones() //con virtual, en director podremos usar override (buena praxis)
        {
            Debug.WriteLine("GETVACIONES EMPLEADO");
            return 22;
        }

    }

}

    //TODO EMPLEADO COBRARÁ SIEMPRE 1000 EUROS
    //crear clase Director -> hereda de empleado y cobrará 200 euros más

