using System;
using System.Linq;

namespace _06_2dArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] array1 = new int[2, 10]; //empty 2d array

            int[,] array2 =
            {
                {18,19,20,10,15,8 },
                {10,12,13,8,9,2 }
                
            }; //direct 2d array
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    Console.Write(array2[i, j] + "\t");
                }// after every row , take new line
                Console.WriteLine();
            }

            //Console.WriteLine(array2[row,column]);

            double[] total = new double[6]; //same length as row

            //total=(0.3*first row) + (0.7*second row)

            for (int i = 0; i < total.Length; i++)
            {
                total[i] = (0.3 * array2[0,i]) + (0.7 * array2[1,i]);

            }
            Console.WriteLine(total.Average());

        }
    }
}