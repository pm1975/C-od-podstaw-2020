using System;
using System.Collections.Generic;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // namber of days in a week
            var number = 5d;
            var list = new List<int>();

            var dictionary = new Dictionary<string, int>();

            var date = new DateTime(2020, 7, 13, 14, 38, 0);          

            Console.WriteLine(date.Date);
            Console.WriteLine(date.ToLongDateString());

        }
    }
}
