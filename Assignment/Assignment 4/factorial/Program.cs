using System;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            
            if (a > 0)
            {
                int number1 = 1;
                int number2 = 1;
                int number3;

                while (number2 <= a) 
                {
                    number3 = number1 * number2;
                    number1 = number3;
                    number2 = number2 + 1;

                    if (number2 > a)
                    {
                        Console.WriteLine(number3);
                    }
                }
            }
            else if (a == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}
