using System;

namespace methodExtenson
{
    internal class Program
    {
        static void print(int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine($"numbers is {number}");
            }
        }

        static void newOne(int number=0) 
        {
            Console.WriteLine("value is "+number);
        }

        static int[] fill (int length , int content)
        {
            int[] filledArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                filledArray[i] = content;
            }
            return filledArray;
        }

        static void print2(int[] array) 
        {
            foreach (var item in array)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine("\n");
        }        

        static void Add(int[] array)
        {
            for (int i = 0; i <array.Length; i++)
            {
                array[i] += 1;
            }
            
           // print(array);
        }

        static void Main(string[] args)
        {
            int[] myArray = { 5, 2, 6, 10 };
            print(myArray);

            newOne();

            int[] myArray2 = fill(10,0);
            print2(myArray2);

            print(myArray);
            Add(myArray);
            print(myArray);

        }
    }
}
