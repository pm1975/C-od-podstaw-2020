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

            switch (priority)
            {
                case Priority.One:
                    break;
                case Priority.Two:
                    break;
                case Priority.Three:
                    break;
                case Priority.Four:
                    break;
                case Priority.Five:
                    break;
                default:
                    break;
            }

            var number = 5;

            switch (number)
            {
                case 3:
                    {

                    } break;
                case 4:
                    {

                    } break;
                default:
                    break;
            }

            Console.WriteLine(priority.ToString());

        }
    }
}
