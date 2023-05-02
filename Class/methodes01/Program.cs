using System;

namespace methodes01
{
    internal class Program
    {
        static void printArray(int[] inputArray)
        {
            //int[] array = { 2, 5, 10, 9 };

            for (int i = 0; i<inputArray.Length; i++)
            {
                Console.WriteLine(inputArray[i]);
            }

        }

        static int arraySum(int[] inputArray) 
        {
            int sum = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                sum += inputArray[i];
            }
            return sum;
        }

        static void helloWorld()
        {
            Console.WriteLine("hello world");
        }


        static void Main(string[] args)
        {

            helloWorld();

            int[] myArray = { 1, 2, 3 };
            printArray(myArray);

            

            int[] array2 = { 4,5,6,7 };
            arraySum(array2);
            Console.WriteLine();
        }
    }
}
