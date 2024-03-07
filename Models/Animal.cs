using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos_CSHARP.Models
{
    internal class Animal
    {
        public string Familia { get;  set; }
        public string Sonido { get; set; }
        public byte Tamaño { get; set; }
        public string Nombre { get; set; }
        public int Velocidad { get; set; }

        public Animal(string Familia, string Sonido, string Nombre, byte Tamaño, byte Velocidad)
        {
            this.Familia = Familia;
            this.Sonido = Sonido;
            this.Tamaño = Tamaño;
            this.Nombre = Nombre;
            this.Velocidad = Velocidad;
        }

        public string HacerSonido()
        {
            return this.Sonido;
        }
    }
}
