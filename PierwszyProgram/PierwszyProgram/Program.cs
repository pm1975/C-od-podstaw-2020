using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace PierwszyProgram
{
    class Program
    {
        enum Priority
        {
            One = 1,
            Two,
            Three,
            Four,
            Five
        }
        static void Main(string[] args)
        {
            var priority = Priority.Three;

            Console.WriteLine(priority.ToString());

        }
    }
}
