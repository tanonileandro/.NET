using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Agilidad { get; set; }
        public int Magia { get; set; }

        public abstract double CalcularDanio();
        public virtual void Atacar()

        {
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de daño.");
        }
    }

}
