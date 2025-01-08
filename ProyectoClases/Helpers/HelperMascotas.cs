using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClases.Models;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        private string Path;
        public HelperMascotas(string path)
        {
            this.Mascotas = new List<Mascota>();
            this.Path = path;
        }

        //NECESITAMOS LEER/ESCRIBIR MASCOTAS DE ESTA COLECCION
        //CONVERTIR COLECCION A STRING
        private string ConvertirMascotasString()
        {
            //queremos esto -> GARFIELD,GATO@PLUTO,PERRO
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                string temp = mascota.Nombre + "," + mascota.Raza;
                data += temp + "@";
            }

            data = data.TrimEnd('@');
            return data;
        }

        //CONVERTIR EL STRING DEL READ A COLECCION MASCOTAS
        private void ConvertirMascotasList(string data)
        {
            //limpiar coleccion actual
            this.Mascotas.Clear();
            //separamos el string por cada amscota @
            string[] datosMascotas = data.Split("@");
            foreach (string stringMascota in datosMascotas)
            {
                string[] propiedades = stringMascota.Split(",");
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        //NECESITAMOS LEER/ESCRIBIR MASCOTAS DE ESTA COLECCION
        public async Task WriteMascotasAsync()
        {
            //convertimos la coleccion a string
            string data = this.ConvertirMascotasString();
            await HelperFiles.WriteFileAsync(this.Path, data);
        }

        public async Task ReadMascotasAsync()
        {
            //leemos el fichero
            string data = await HelperFiles.ReadFileAsync(this.Path);
            this.ConvertirMascotasList(data);
        }
    }
}
