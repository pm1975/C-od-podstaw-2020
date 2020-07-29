using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PierwszyProgram
{
    class Program
    {
        enum Number
        {
            Even,
            Odd
        }
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var numberType = (Number)(number % 2);

            Console.WriteLine(numberType.ToString());

            /*
            var reminder = number % 2;
            if (reminder == 0)
            {
                Console.WriteLine("Parzysta");
            }
            else
            {
                Console.WriteLine("Nieparzysta");
            }
            */
        }
    }
}
