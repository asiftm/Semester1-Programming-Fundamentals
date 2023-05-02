using System;

namespace DecimalPart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = Convert.ToDouble(Console.ReadLine());

            int number2 = (int)(number1);

            double number3 = number1-number2;

            string number4 = number3.ToString("N6");

            Console.WriteLine("Decimal part = " + number4);
        }
    }
}
