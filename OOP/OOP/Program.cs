using OOP.Files;
using System;

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
            var calculator = new Calculator<double>();

            Console.WriteLine("Wpisz proszę dwie liczby oddzielone enterem: ");
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Wpisz proszę działanie, które chcesz wykonać");
            Console.WriteLine("Dostępne działania to: + - * /");

            var operation = Console.ReadLine();

            var result = default(double);

            switch (operation)
            {
                case "+":
                    {
                        result = calculator.Add(firstNumber, secondNumber);
                    }
                    break;
                case "-":
                    {
                        result = calculator.Substract(firstNumber, secondNumber);
                    }
                    break;
                case "*":
                    {
                        result = calculator.Multiply(firstNumber, secondNumber);
                    }
                    break;
                case "/":
                    {
                        result = calculator.Divide(firstNumber, secondNumber);
                    }
                    break;
            }

            Console.WriteLine(result);
        }
    }

}
