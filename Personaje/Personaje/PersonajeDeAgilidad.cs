using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class PersonajeDeAgilidad : Personaje, IMoverse
    {
        public PersonajeDeAgilidad(string nombre, int fuerza, int agilidad, int magia)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = magia;
        }

        public override double CalcularDanio()
        {
            return Fuerza / 2 * Agilidad * Magia / 2;
        }

        public void MoverseEjeX()
        {
            Console.WriteLine("Personaje de Agilidad se movió en el eje X.");
        }

        public void MoverseEjeY()
        {
            Console.WriteLine("Personaje de Agilidad se movió en el eje Y.");
        }
    }
}
