using System;

namespace May_the_odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input1 = Convert.ToInt32(Console.ReadLine());
            double input2 = Convert.ToInt32(Console.ReadLine());

            double b = 1; 
            double c = 1;

            if(input1<input2)
            {
                for (double i = input1; i <= input2; i++)
                {
                    double remainder = i % 2;
                    if (remainder != 0)
                    {
                        c = i * b;
                        b = c;
                    }
                }
                Console.WriteLine(c);
            }  
            
            else if(input1>input2)
            {
                for (double i = input2; i <= input1; i++)
                {
                    double remainder = i % 2;
                    if (remainder != 0)
                    {
                        c = i * b;
                        b = c;
                    }
                }
                Console.WriteLine(c);

            }
        }
    }
}
