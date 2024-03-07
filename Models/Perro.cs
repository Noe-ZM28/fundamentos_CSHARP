using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fundamentos_CSHARP.Models
{

    class Perro : Animal
    {
        public Perro(string Familia, string Sonido, string Nombre, byte Tamaño, byte Velocidad) : base(Familia, Sonido, Nombre, Tamaño, Velocidad)
        {
            this.Familia = Familia;
            this.Sonido = Sonido;
            this.Tamaño = Tamaño;
            this.Nombre = Nombre;
            this.Familia = Familia;
            this.Velocidad = Velocidad;
        }

        public void Correr(int Kilometros)
        {
            float Tiempo = Kilometros / this.Velocidad;
            string horas = Tiempo > 1 ? " horas" : " hora";
            Console.WriteLine("El tiempo que tardo " + this.Nombre + " en recorrer " + Kilometros + " Km fue de: " + Tiempo + horas);

        }
    }
}
