using System;
using System.Collections.Generic;

namespace classTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("new student? Y/N");
            string answer = Console.ReadLine().ToLower();

            Dictionary<string, double> perEv = new Dictionary<string, double>();
            Dictionary<string, double> exEv = new Dictionary<string, double>();
            Dictionary<string, double> total = new Dictionary<string, double>();

            while (answer == "y")
            {
                Console.WriteLine("what is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("what is your assignment point?");
                double perEvPoint = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("what is your exam point?");
                double exEvPoint = Convert.ToInt32(Console.ReadLine());

                perEv.Add(name, perEvPoint);
                exEv.Add(name,exEvPoint);
                total.Add(name,( 0.3 * perEvPoint + 0.7 * exEvPoint ));


                Console.WriteLine("new student? Y/N");
                answer = Console.ReadLine().ToLower();
            }

            foreach (var item in total.Keys)
            {
                Console.WriteLine(total[item]);
            }

        }
    }
}
