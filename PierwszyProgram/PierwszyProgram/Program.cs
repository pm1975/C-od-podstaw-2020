using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var variable = 5;
            string nameOfVariable = nameof(variable);

            var type = typeof(DateTime);
            type.GetMethods();

            Console.WriteLine(nameOfVariable);

        }
    }
}
