using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        //todas las propiedas van a ser autoimplementadas
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }

        public Direccion()
        {
            Debug.WriteLine("Constructor DIRECCION sin parámetros");
        }

        public Direccion(string calle, string ciudad)
        {
            //ponemos this para acceder a las propeidades de la clase porque en el metodo, podemos llamar a la variable igual y es para diferenciarlas
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor DIRECCION con 2 parámetros");
        }

        public Direccion(string calle, string ciudad, int cp)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;

            Debug.WriteLine("Constructor DIRECCION con 3 parámetros");
        }
    }
}
