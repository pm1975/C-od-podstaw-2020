using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyClass myClassObject = new MyClass();

            myClassObject.Function2();
            MyClass.Function1();
        }
    }

    class MyClass
    {
        public static void Function1()
        {

        }

        public void Function2()
        {

        }
    }
}
