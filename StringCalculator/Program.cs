using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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
            var stringArray = rawString.Split(',');

            var intArray = stringArray
                .Select((i) =>
                {
                    int.TryParse(i,out int number);
                    return number;
                })
                .ToArray<int>();

            return intArray.Sum();
        }
    }
}
