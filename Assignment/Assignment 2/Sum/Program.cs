using System;

namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
           
            decimal a = Convert.ToDecimal(Console.ReadLine());
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal c = Convert.ToDecimal(Console.ReadLine());

            int sum =(int)(a + b + c);

            Console.WriteLine(sum);
        }
    }
}
