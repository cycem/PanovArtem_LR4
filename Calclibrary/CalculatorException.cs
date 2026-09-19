using System;

namespace CalcLibrary
{
    public class CalculatorException : Exception
    {
        public CalculatorException(string message) : base(message) { }
    }
}