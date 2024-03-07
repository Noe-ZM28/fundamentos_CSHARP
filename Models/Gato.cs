using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos_CSHARP.Models
{
    internal class Gato : Animal
    {
   
        public Gato(string Familia, string Sonido, string Nombre, byte Tamaño, byte Velocidad) : base(Familia, Sonido, Nombre, Tamaño, Velocidad)
        {
            this.Familia = Familia;
            this.Sonido = Sonido;
            this.Tamaño = Tamaño;
            this.Nombre = Nombre;
            this.Familia = Familia;
            this.Velocidad = Velocidad;
        }
        public void arañar(string mueble)
        {
            System.Console.WriteLine(this.Nombre + " araño el " + mueble);
        }
    }
}
