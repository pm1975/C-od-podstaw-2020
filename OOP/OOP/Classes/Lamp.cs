using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Lamp
    {
        private int Height { get; set; }
        private int Power { get; set; }

        public void LightItself()
        {
            Console.WriteLine(Height);
            Console.WriteLine(Power);
        }

        public Lamp(int height, int power)
        {
            Height = height;
            Power = power;
        }
    }
}
