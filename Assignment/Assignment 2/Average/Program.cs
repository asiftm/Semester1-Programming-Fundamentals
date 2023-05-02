using System;

namespace Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal a = Convert.ToDecimal(Console.ReadLine());
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal c = Convert.ToDecimal(Console.ReadLine());
            decimal d = Convert.ToDecimal(Console.ReadLine());

            int avrege = Convert.ToInt32((a + b + c + d) / 4);

            Console.WriteLine(avrege);  


        }
    }
}
