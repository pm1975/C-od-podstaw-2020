using System;
using System.Collections.Generic;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int>();

            //for (int i = 0; i < 10; i++)
            //{
            //    lista.Add(int.Parse(Console.ReadLine()));
            //}

            //while (lista.Count > 0)
            //{
            //    lista.RemoveAt(0);
            //}

            //do
            //{

            //} while (lista.Count > 0);

            lista.Add(5);
            lista.Add(3);
            lista.Add(7);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
