using System;

namespace ascii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());   
            char ascii = Convert.ToChar(num);
            
            String ascii2 = Convert.ToString(ascii);
            string lower = ascii2.ToLower();

            Console.WriteLine(lower);
            Console.WriteLine(ascii2);

        }
    }
}
