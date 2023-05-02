using System;

namespace Polynomial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

                string[] array = input.Split(" ");

                int firstNumber = int.Parse(array[0]);

                double secondNumber = double.Parse(array[1]);

                double symbol = -1;

                double value = 0;
                double total = 0;


                for (double i = 0; i <= firstNumber; i++)
                {
                    value = (-Math.Pow(secondNumber, i)) * symbol;

                    total = total + value;

                    symbol = symbol * -1;
                }

                string output = total.ToString("0.00");

                Console.WriteLine(output);
            }
            
            catch(FormatException)
            {
                Console.WriteLine("converting problem");
            }
            catch(OverflowException)
            {
                Console.WriteLine("too big for this type");
            }
            catch(Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
