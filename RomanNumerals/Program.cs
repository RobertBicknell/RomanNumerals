using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try 
                {
                    Console.WriteLine("Please enter a Roman Numeral for conversion to Arabic Numerals");
                    var romanNumeral = Console.ReadLine();
                    var arabicNumeral = Converter.Convert(romanNumeral);
                    Console.WriteLine($"{romanNumeral} converts to {arabicNumeral}");
                }
                catch {
                    Console.WriteLine($"Conversion error! Please check the input and try again.");
                }
            }
        }
    }
}
