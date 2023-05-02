using System;

namespace Ending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string input = Console.ReadLine();

            //spliting the input into an array
            string[] array = input.Split(" ");

            //array into two strings
            string firstStr = array[0];
            string secondStr = array[1];

            //variable to store output values
            string store = string.Empty;

            //for the length of second string
            int num = secondStr.Length;


            for (int i = (firstStr.Length - 1); i >= 0; i--) //checking from the last latter of first string
            {
                if(firstStr[i] == secondStr[num-1]) //compairing both strings latter by latter from the ending
                {
                    store = store + firstStr[i]; //similar latters storing in store variable
                    num--;
                }
                else //if the latters are different then breaking the for loop
                {
                    break; //breaking the for loop
                }
            }

            //output values stored in store variable are in backwards.
            for (int j = store.Length - 1; j >= 0; j--) //using for loop to rearange the latters in right order
            {
                Console.Write(store[j]); //printing the values
            }
        }
    }
}




