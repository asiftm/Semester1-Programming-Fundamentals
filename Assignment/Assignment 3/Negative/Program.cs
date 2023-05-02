using System;

namespace Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine($"-{a}");
            }
            else if (a < 0)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("error converting");
            }
        }
    }
}
