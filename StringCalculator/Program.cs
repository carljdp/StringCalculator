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
            var strings = rawString.Split(',');

            var numbers = strings
                .Select((element) =>
                {
                    int.TryParse(element,out var number);
                    return number;
                })
                .ToArray<int>();

            return numbers.Sum();
        }
    }
}
