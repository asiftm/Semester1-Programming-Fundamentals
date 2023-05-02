using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Harmonic_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            double temporary=0;

            Console.Write($"1");
            
            if (input>0)
            {
                for(double i = 2; i <= input; i++)
                {
                    Console.Write($" + 1/{i}");

                    double b = (1 / i);
                    double sum = b + temporary;
                    temporary = sum;
                }
                double total = temporary + 1;
                string result = total.ToString("F4",CultureInfo.InvariantCulture);
                Console.WriteLine($"\nsum = {result}");
            }
        }
    }
}
