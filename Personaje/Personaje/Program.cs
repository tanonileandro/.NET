// See https://aka.ms/new-console-template for more information
using Personaje;
using System;
using System.Collections.Generic;

namespace ProyectoPersonajes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personaje> personajes = new List<Personaje>
            {
                new PersonajeDeFuerza("Personaje1", 50, 20),
                new PersonajeDeAgilidad("Personaje2", 70, 40, 30),
                new PersonajeDeMagia("Personaje3", 60, 30, 50)
            };

            Enemigo enemigo = new Enemigo { Vida = 100, Nivel = 5 };

            Console.WriteLine("Ataque de personajes:");
            Turno.Atacarse(personajes);

            Console.WriteLine("\nMovimiento de fichas:");
            Turno.MoverFichas(enemigo);
        }
    }
}