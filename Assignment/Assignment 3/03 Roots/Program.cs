using System;

namespace _03_Roots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double D = Math.Pow(b,2)-4*a*c ;

            double root1 = ((-b + Math.Sqrt(D)) / (2*a));
            double root2 = ((-b - Math.Sqrt(D)) / (2*a));

            if (D > 0)
            {
                Console.WriteLine(root1 + " " + root2);
            }
            else if (D == 0)
            {
                Console.WriteLine(root1);
            }
            else
            {
                Console.WriteLine("no real solution");
            }




        }
    }
}
