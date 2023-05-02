using System;
using System.Runtime.ExceptionServices;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string num = Console.ReadLine();
            //int number;
            //bool success = int.TryParse(num, out number);
            
            //int number = 5;
            int number = Convert.ToInt32(Console.ReadLine());

            int first = 1, second = 1, tamp=0;
            

            
                for (int i = 1; i <= number; i++)
                {
                    tamp = first * second;
                    first = tamp;
                    second = second + 1;
                }
                Console.WriteLine(tamp);
            


        }
    }
}