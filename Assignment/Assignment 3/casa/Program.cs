using System;

namespace casa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character = Convert.ToChar(Console.ReadLine());
            int number = Convert.ToInt32(character);


            if  (65 <= number & number <= 90)  //according to ascii table

            {
                Console.WriteLine("uppercase");
            }
            else if (97 <= number & number <= 122)
            {
                Console.WriteLine("lowercase");
            }
            else
            {
                Console.WriteLine("crazy input");
            }

        }
    }
}
