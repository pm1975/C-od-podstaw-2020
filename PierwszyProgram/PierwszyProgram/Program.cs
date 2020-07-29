using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var variable = default(DateTime);

            if (true)
            {
                variable = new DateTime();
            }
            else
            {
                variable = new DateTime(2);
            }

            variable = default(DateTime);

            Console.WriteLine(variable);

        }
    }
}
