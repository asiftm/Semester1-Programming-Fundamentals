using System;

namespace Next_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int firstnumber = 1;
            int secondnumber = 1;
            int temporary=0;

            for (int i = 0; i <input; i++)
            {
                temporary = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = temporary;

                if(secondnumber==input)
                {
                    int b = (firstnumber + secondnumber);

                    Console.WriteLine(b); 
                }
            }
        }
    }
}
