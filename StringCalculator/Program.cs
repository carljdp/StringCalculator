using System;
using System.ComponentModel;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class Calculator
    {
        public static int Add(string rawString)
        {
            var number = 0;

            int.TryParse(rawString, out number);

            return number;
        }
    }
}


