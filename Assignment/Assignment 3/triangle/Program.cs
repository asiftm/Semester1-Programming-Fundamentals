using System;

namespace triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0)
            {
                if (a == b && a == c)
                {
                    Console.WriteLine("equilateral");
                }
                else if (a == b || a == c)
                {
                    Console.WriteLine("isosceles");
                }
                else
                {
                    Console.WriteLine("scalene");
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }



















            /*double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == b && a == c)
            {
                Console.WriteLine();
            }
            else if (a == c || b == c)
            {
                Console.WriteLine();
            }
            else
            {

            }
            */
        }
    }
}
