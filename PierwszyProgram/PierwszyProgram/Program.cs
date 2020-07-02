using System;
using System.Collections.Generic;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int>();

            lista.Add(int.Parse(Console.ReadLine()));
            lista.Add(int.Parse(Console.ReadLine()));


            if (lista[0] > lista[1])
            {
                Console.WriteLine("Liczba1 jest większa");
            }
            else if (lista[0] < lista[1])
            {
                Console.WriteLine("Liczba1 jest mniejsza");
            }
            else
            {
                Console.WriteLine("Takie same liczby");
            }

        }
    }
}
