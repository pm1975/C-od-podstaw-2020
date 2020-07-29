using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Classes
{
    class Desk : Item
    {
        private int Widht { get; set; }

        public Desk(int height, int widht)
        {
            Height = height;
            Widht = widht;
        }
    }
}
