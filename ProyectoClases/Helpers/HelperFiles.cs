using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        //necesitamos los metodos leer y escribir
        //con estos metodos, debemos usar aync/await
        //cuando creemos metodos async/await propios, debemos usar la clase task
        //no se usa void
        //si se usa void: task
        //si es un return: Task<ClaseReturn>
        public static async Task<string> ReadFileAsync(string path) //ponemos el Task porque va a ser un return
        {
            FileInfo file = new FileInfo(path);
            using (TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }

        public static async Task WriteFileAsync(string path, string data)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();
            }
        }
    }
}
