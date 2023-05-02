using System;

namespace largest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            double number3 = Convert.ToDouble(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine(number1);
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine(number3);
            }

        }
    }
}
