using System;

namespace Circumference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            int w = Convert.ToInt32(Console.ReadLine());

            int circumference = 2 * (l + w);

            Console.WriteLine(circumference);
        }
    }
}
