using OOP.Classes;
using OOP.Files;
using System;
using System.IO;

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

            myLamp2.LightItself();

            var fileManager = new FileManager();

            fileManager.SaveLamp(myLamp);

            var databaseManager = new DatabaseManager();

            databaseManager.SaveLamp(myLamp);
        }
    }

}
