using System;

namespace Symmetric_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];

            Console.WriteLine("Enter the values of the array:");
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            bool symmetric = true;

            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[length - i - 1])
                {
                    symmetric = false;
                    break;
                }
            }
            Console.WriteLine("Is symmetric? {0}", symmetric);
        }
    }
}
