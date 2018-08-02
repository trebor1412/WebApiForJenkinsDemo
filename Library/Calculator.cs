using System;

namespace Library
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b) => a + b;


        public int Minus(int a, int b) => a - b;
    }
}