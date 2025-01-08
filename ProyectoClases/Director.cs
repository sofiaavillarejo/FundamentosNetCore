using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    //hereda de la clase Empleado
    public class Director: Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor DIRECTOR");
            //cojo lo que tiene ya un empleado y le sumo 200
            this.SalarioMinimo += 200;
        }

        //crear metodo override para sobreescribir los dias de vacaciones
        public override int GetDiasVacaciones() //si en el otro metodo no tenemos virtual, aqui en vez de override usamos new
        {
            Debug.WriteLine("GETVACACIONES Director");
            int vacacionesEmpleado = base.GetDiasVacaciones();
            return vacacionesEmpleado + 8;
        }

        public int GetDiasVacaciones(int extras)
        {
            return this.GetDiasVacaciones() + extras;
        }
    }
}
