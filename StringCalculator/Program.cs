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
            int result=-1;

            int.TryParse(rawString, out result);

            return result;
        }
    }
}
