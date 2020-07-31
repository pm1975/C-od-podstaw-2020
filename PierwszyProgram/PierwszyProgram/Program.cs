using System;
using System.IO;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "imiona.txt";

            // Sprawdź, czy mamy jakieś nazwisko zapisane
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                if (fileContent.Length > 0)
                {
                    // Jeśli tak, wypisujemy i pytamy o usunięcie
                    Console.WriteLine("Imie zapisane to: " + fileContent);
                    Console.WriteLine("Czy chcesz usunąć to imię?");

                    var userAnswer = Console.ReadLine();
                    if (userAnswer == "Tak")
                    {
                        // Jeśli usunął, wczytujemy nowe
                        File.Delete(filePath);
                    }
                    else
                    {
                        // Jeśli nie usunął, kończymy program
                        return;
                    }
                }
            }

            // Jeśli nie, wczytujemy i zapisujemy
            Console.WriteLine("Podaj proszę swoje imię: ");
            var userName = Console.ReadLine();

            File.WriteAllText(filePath, userName);
        }
    }
}
