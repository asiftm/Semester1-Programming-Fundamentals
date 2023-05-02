using System.Runtime.InteropServices;

namespace combining
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("what is your age?");
            int age=Convert.ToInt32(Console.ReadLine());

            /*           if (age<18)
                       {
                           Console.WriteLine("no work");
                       }
                       else if (age < 65)
                       {
                           Console.WriteLine("work");
                       }
                       else
                       {
                           Console.WriteLine("no work");
                       }*/

            if ((age < 18) || (age > 65))
            {
                Console.WriteLine("no work");
            }
            else
            {
                Console.WriteLine("work");
            }
        }
    }
}