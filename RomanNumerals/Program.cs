using System;

namespace RomanNumerals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                try
                {
                    var result = NumeralConverter.ConvertRomanNumeralToInt(arg);
                    Console.WriteLine($"Roman numeral {arg} converted to {result}");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"Roman numeral {arg} failed to convert {e.Message}");
                }
            }
        }
    }
}