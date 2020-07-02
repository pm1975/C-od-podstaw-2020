using System;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double liczba1 = 15;
            var liczba2 = 8;
            var suma = liczba1 + liczba2;
            var roznica = liczba1 - liczba2;
            var mnozenie = liczba1 * liczba2;
            var dzielenie = liczba1 / liczba2;
            var modulo = liczba1 % liczba2;

            Console.WriteLine(suma);
            Console.WriteLine(roznica);
            Console.WriteLine(mnozenie);
            Console.WriteLine(dzielenie);
            Console.WriteLine(modulo);

            var napis1 = "Kurs";
            var napis2 = "programowania";

            Console.WriteLine(napis1 + " " + napis2);

        }
    }
}
