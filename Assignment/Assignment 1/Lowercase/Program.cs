using System;

namespace Lowercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            string animel=Console.ReadLine();
            string lowercase = animel.ToLower();

            Console.WriteLine(name + ", your favorite animal is " + lowercase);

         
        }
    }
}
