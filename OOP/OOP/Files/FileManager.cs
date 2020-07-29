using OOP.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP.Files
{
    class FileManager : IManager
    {
        public void SaveLamp(Lamp lamp)
        {
            var path = "lamp.txt";
            var content = "Lampa: " + "wysokość - " + lamp.Height + ", moc - " + lamp.Power;
            File.WriteAllText(path, content);
        }
    }
}
