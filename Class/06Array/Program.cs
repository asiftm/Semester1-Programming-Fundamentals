using System;

namespace _06Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           


            //regular variable
            int myVariable1;
            int myVariable2 = 1;

             //array of variable (int):version 1
            
            int[] myArray2 = { 10, 2, 13, 1, 9 , 6 };

            Console.WriteLine(myArray2[4]);

            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.WriteLine(myArray2[i]);
            }


            string[] namesArray = new string[5];
            namesArray[0] = "Tristan";
            namesArray[1] = "Colin";
            namesArray[2] = "Elek";
            for (int i = 1; i==1; i++)
            {
                Console.WriteLine(namesArray[1]);
            }

            Console.WriteLine(namesArray[0]);

            for (int i = 0; i < namesArray.Length; i++)
            {
                namesArray[i] = Console.ReadLine();
            }

            string names = Console.ReadLine();
            string[] namesArray2=names.Split(" ");
            
            
        }
    }
}
