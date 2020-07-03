using System;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //double liczba = 8.12312;
            //NazwaFunkcji();
            //var liczba2 = PodwojLiczbe(PrzekonwertujDoubleNaInta(liczba));
            //Console.WriteLine(liczba2);
            var liczba = 5;
            Console.WriteLine(liczba);
            Console.WriteLine(PodwojLiczbe(liczba));
            Console.WriteLine(liczba);
            Console.WriteLine(PodwojLiczbe1(out liczba));
            Console.WriteLine(liczba);

        }

        private static void NazwaFunkcji()
        {
            Console.WriteLine(5);
        }

        private static int PodwojLiczbe(int liczba)
        {
            return liczba * 2;
        }

        private static int PodwojLiczbe1(out int liczba)
        {
            liczba = 2;
            return liczba * 2;
        }

        private static int PrzekonwertujDoubleNaInta(double liczba)
        {
            if (int.TryParse(liczba.ToString(), out int liczba2))
            {
                return liczba2;
            }
            else
            {
                return 0;
            }
        }

    }
}
