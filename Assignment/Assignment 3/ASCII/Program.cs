using System;

namespace ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            char character = Convert.ToChar(number);

            if (number < 65)
            {
                Console.WriteLine("A");
            }
            else if (number >= 65 && number <= 90)
            {
                Console.WriteLine(character);
            }
            else if (number >= 91 && number <= 96)
            {
                if (number < 94)
                {
                    Console.WriteLine("Z");
                }
                else
                {
                    Console.WriteLine("a");
                }
            }
            else if (number >= 97 && number <= 122)
            {
                Console.WriteLine(character);
            }
            else
            {
                Console.WriteLine("z");
            }
            //according to ASCII table
        }
    }
}
