using System;
using System.Globalization;

namespace Radius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            double area = Convert.ToDouble(Console.ReadLine());

            double radius = (Math.Sqrt(area / Math.PI ));

            string radius1 = radius.ToString("F2",CultureInfo.InvariantCulture);

            Console.WriteLine(radius1);
        }
    }
}
