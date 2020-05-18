using System;
using System.Linq;

namespace RomanNumerals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Count() > 0)
            {
                foreach (var arg in args)
                {
                    HandleInput(arg);
                }
            }
            else
            {
                string input;
                while(true)
                {
                    Console.Write("Enter a roman numeral - Q to quit \n");
                    input = Console.ReadLine();

                    if (input == "Q")
                        break;

                    HandleInput(input);
                }
            }
        }

        private static void HandleInput(string arg)
        {
            try
            {
                var result = NumeralConverter.ConvertRomanNumeralToInt(arg);
                Console.WriteLine($"Roman numeral {arg} converted to {result}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Roman numeral {arg} failed to convert. Error: {e.Message}");
            }
        }
    }
}