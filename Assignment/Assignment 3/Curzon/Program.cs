using System;

namespace Curzon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number1;
            bool success = Int32.TryParse(input, out number1);

            double number2 = (Math.Pow(2, number1))+1;
            double number3 =((2 * number1) + 1);
            double number4 = number2 % number3;

            if (success)
            {
                if (number1 > 0)
                { 
                    if (number4 == 0)
                    {
                        Console.WriteLine("TRUE");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else
                {
                    Console.WriteLine("crazy input");
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
