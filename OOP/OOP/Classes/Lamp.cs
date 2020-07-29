﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Classes
{
    class Lamp : Item
    {
        public int Power { get; private set; }

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
