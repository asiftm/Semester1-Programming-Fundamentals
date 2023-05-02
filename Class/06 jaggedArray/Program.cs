using System;

namespace _06_jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[][] myJaggedArray = new int[5][]; //second one is empty because column numbers are not fixed

            myJaggedArray[0] = new int[2];

            //one way to fill it up
            myJaggedArray[0][0] = 19;
            myJaggedArray[0][1] = 7;
            //another way to fill it up
            myJaggedArray[1] = new int[] { 19, 4, 20, 10, 5 };

            //looping over the rowa
            for (int i = 0; i < myJaggedArray.Length; i++)
            {
                //each row has a different length ,so watch out
                for (int j = 0; j < myJaggedArray[i].Length; j++)
                {
                    //printing out each element
                    Console.Write(myJaggedArray[i][j] + "\t");
                }
                //each row gets a new line
                Console.Write("\n");
            }
        }
    }
}
