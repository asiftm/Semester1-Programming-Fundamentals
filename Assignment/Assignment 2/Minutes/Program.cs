using System;

namespace Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minute = Convert.ToInt32(Console.ReadLine());

            int second = minute * 60;

            int hour = minute / 60;

            Console.WriteLine( second + " seconds");
            Console.WriteLine(hour + " hour(s)");
        }
    }
}
