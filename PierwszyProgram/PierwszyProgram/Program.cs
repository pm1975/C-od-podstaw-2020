using System;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var napis1 = "Kurs";
            var napis2 = "programowania";

            var liczba1 = 5;
            var liczba2 = 5;

            if (liczba1 == liczba2)
            {
                Console.WriteLine(napis1 + " " + napis2);
            }
            else
            {
                Console.WriteLine("Jesteśmy po ifie");
            }

            Console.WriteLine("Podaj liczby");

            var liczba11 = int.Parse(Console.ReadLine());
            var liczba12 = int.Parse(Console.ReadLine());

            if (liczba11 > liczba12)
            {
                Console.WriteLine("Liczba1 jest większa");
            }
            else if (liczba11 < liczba12)
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
