using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    //PROPIEDADES ENUMERADAS
    //pero hay que comprobar el valor que se nos está ofreciendo
    public enum TipoGenero {  Masculino, Femenino }

    //TAMBIÉN SE PUEDEN PONER NUMEROS
    public enum TipoGenero2 { Masculino = 0, Femenino = 1 }

    public enum Paises {  España, Francia, Alemania, Andorra, Tabarnia }

    public class Persona
    {
        public Persona()
        {
            //esta linea se ve al ejecutar en la ventana Output
            //a la hora de poner esto, el constructor está vacío y por ello, nos indica que no tiene parametros
            Debug.WriteLine("Constructor vacío PERSONA");

            //creamos la instancia de Direccion() en este caso, aqui en la clase (tambien lo hemos hecho en el form)
            this.Domicilio = new Direccion();
        }

        //creamos otro constructor que va a recibir parámetros
        public Persona(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor PERSONA 2 parametros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        #region PROPIEDADES
        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set { 
                Random random = new Random();
                int aleat = random.Next(1, 20);
                this._DescripcionThis = "Descripción " + aleat;
            }
        }
        public Direccion Domicilio { get; set; }
        public Direccion DomiciloVacaciones { get; set; }

        //propiedades autoimplementadas
        public TipoGenero Genero { get; set; }

        private TipoGenero2 _Genero;
        public TipoGenero2 Genero2
        {
            get { return this._Genero; }
            set
            {
                //CODIGO PARA EVITAR QUE EL USUARIO META EN GENERO UN NUMERO POR EJEMPLO
                if (value != TipoGenero2.Masculino && value != TipoGenero2.Femenino)
                {
                    throw new Exception("Valor de género incorrecto");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }

        public Paises Nacionalidad { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        //public string Nombre;
        //public string Apellidos;

        //CAMPO PRIVADO PARA LA EDAD, VAMOS A COMPROBAR EL CAMPO EDAD
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set
            {
                //COMPROBAMOS EL VALOR DE EDAD QUE VIENE EN value
                if (value < 0)
                {
                    //SI NOS DAN UN VALOR INCORRECTO
                    //Error silencioso -> le cambiamos el valor y ya esta
                    //this._Edad = 0;

                    // O LANZAR UNA EXCEPCIÓN
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    //TODO CORRECTO
                    this._Edad = value;
                }
            }
        }
        #endregion

        #region METODOS
        //método para devolver un nombre completo
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        //estamos devolviendo un método con el Nombre y Apellidos
        
        //Ahora quiero un método para devolver los apellidos y el nombre
         public string GetNombreCompletoReves()
        {
            return this.Apellidos + " " + this.Nombre;
        }

        //metodo para devolver el nombre completo en mayuscula
        //public string GetNombreCompletoMayuscula()
        //{
        //    return (this.Nombre + " " + this.Apellidos).ToUpper();
        //}
        // public string GetNombreCompleto(bool mayusculas)
        //{
        //    if (mayusculas == true)
        //    {
        //        return (this.Nombre + " " + this.Apellidos).ToUpper();
        //    }
            
        //}
        public string GetNombreCompleto(int orden)
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(int num1, int num2)
        {
            return "";
        }

        //metodo para devolver el nombre completo en minuscula
        public string GetNombreCompletoMinuscula()
        {
            return (this.Nombre + " " + this.Apellidos).ToLower();
        }
        #endregion

    }
}
