using System;

namespace roman_to_decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();

            int output = 0;

            foreach (char character in input)
            {
                switch(character)
                {
                    case'M': output += 1000; break;
                    case'D': output += 500; break;
                    case'C': output += 100; break;
                    case'L': output += 50; break;
                    case'X': output += 10; break;
                    case'V': output += 5; break;
                    case'I': output += 1; break;
                }
            }
            Console.WriteLine(output);
        }
    }
}
