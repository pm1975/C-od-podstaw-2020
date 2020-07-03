using System;
using System.Collections.Generic;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            NazwaFunkcji();
            var liczba = 8;
            var liczba2 = PodwojLiczbe(liczba);
            Console.WriteLine(liczba2);
        }

        private static void NazwaFunkcji()
        {
            Console.WriteLine(5);
        }

        private static int PodwojLiczbe(int liczba)
        {
            return liczba * 2;
        }
    }
}
