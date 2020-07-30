using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Calculator<T>
    {
        public T Add(T first, T second)
        {
            dynamic firstNumber = first;
            dynamic secondNumber = second;
            return firstNumber + secondNumber;
        }

        public T Substract(T first, T second)
        {
            return (dynamic)first - (dynamic)second;
        }

        public T Multiply(T first, T second)
        {
            return (dynamic)first * (dynamic)second;
        }

        public T Divide(T first, T second)
        {
            return (dynamic)first / (dynamic)second;
        }
    }
}
