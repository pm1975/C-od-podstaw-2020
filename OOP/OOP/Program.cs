using OOP.Classes;
using OOP.Files;
using System;
using System.IO;

namespace OOP
{
    class Program
    {
        public static IManager GetManager()
        {
            return new FileManager();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Lamp myLamp = new Lamp(200, 100);

            myLamp.LightItself();

            Lamp myLamp2 = new Lamp(300, 150);

            myLamp2.LightItself();

            var manager = GetManager();

            manager.SaveLamp(myLamp);
        }
    }

}
