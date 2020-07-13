using System;
using System.Collections.Generic;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int>();

            var slownik = new Dictionary<string, int>();

            var dataWKalendarzu = new DateTime(2020, 7, 13, 14, 38, 0);          

            Console.WriteLine(dataWKalendarzu.Date);
            Console.WriteLine(dataWKalendarzu.ToLongDateString());

        }
    }
}
