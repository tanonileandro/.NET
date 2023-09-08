using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class PersonajeDeFuerza : Personaje, IMoverse
    {
       public PersonajeDeFuerza(string nombre, int agilidad, int magia) 
        { 
            Nombre = nombre;
            Fuerza = 100;
            Agilidad = agilidad;
            Magia = magia;
        }

        public override double CalcularDanio()
        {
            return Fuerza + Agilidad + Magia;
        }

        public void MoverseEjeX()
        {
            Console.WriteLine("Personaje de Fuerza se movió en el eje X.");
        }

        public void MoverseEjeY()
        {
            Console.WriteLine("Personaje de Fuerza se movió en el eje Y.");
        }
    }
}
