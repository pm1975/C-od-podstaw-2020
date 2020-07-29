using OOP.Classes;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Lamp myLamp = new Lamp(200, 100);

            myLamp.LightItself();

            Lamp myLamp2 = new Lamp(300, 150);

            myLamp.LightItself();
        }
    }

}
