using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Classes
{
    class Lamp : Item
    {
        private int _power;
        public int Power
        {
            get
            {
                return _power;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Próbowano ustanić nieprawidłową wartość mocy lampy");
                    return;
                }

                _power = value;
            }
        }

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
