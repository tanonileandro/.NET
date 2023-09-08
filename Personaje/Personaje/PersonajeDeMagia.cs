using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personaje
{
    public class PersonajeDeMagia : Personaje, IMoverse
    {
        public PersonajeDeMagia(string nombre, int fuerza, int agilidad, int magia)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = magia;
        }

        public PersonajeDeMagia(string nombre, int fuerza, int agilidad)
        {
            Nombre = nombre;
            Fuerza = fuerza;
            Agilidad = agilidad;
            Magia = 60;
        }

        public override double CalcularDanio()
        {
            return Fuerza + Agilidad + Magia * 4;

        }

        public override void Atacar()
        {
            CalcularDanio();
            Console.WriteLine($"{Nombre} hizo {CalcularDanio()} de daño gracias a su magia.");
        }

        public void MoverseEjeX()
        {
            Console.WriteLine("Personaje de Magia se movió en el eje X.");
        }

        public void MoverseEjeY()
        {
            Console.WriteLine("Personaje de Magia se movió en el eje Y.");
        }
    }

}
