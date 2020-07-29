using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Lamp myLamp = new Lamp();
            myLamp.Height = 200;
            myLamp.Power = 100;

            myLamp.LightItself();

            Lamp myLamp2 = new Lamp();
            myLamp.Height = 300;
            myLamp.Power = 150;

            myLamp.LightItself();
        }
    }

    class Lamp
    {
        public int Height { get; set; }
        public int Power { get; set; }

        public void LightItself()
        {
            Console.WriteLine(Height);
            Console.WriteLine(Power);
        }
    }
}
