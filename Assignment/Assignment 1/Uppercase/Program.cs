using System;
namespace Uppercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            string upperName=name.ToUpper();

            Console.WriteLine("HELLO "+upperName);
        }
    }
}