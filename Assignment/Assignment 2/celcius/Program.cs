using System;
using System.ComponentModel;
using System.Globalization;

namespace celcius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C = Convert.ToDouble(Console.ReadLine());

            double K = C + 273 ;

            double F = C * 18 / 10 + 32 ;

            string k2 = K.ToString("N3");
            string f2 = F.ToString("N3");


            Console.WriteLine(k2 + "°K");
            Console.WriteLine(f2 + "°F");
        }
    }
}
