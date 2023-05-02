using System;

namespace _04fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 10;

            int firstNumber=1;
            int secondNumber=1;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            int temp;

            for (int i = 0; i < length-2; i++)
            {
            temp = firstNumber + secondNumber;
            Console.WriteLine(temp);
            firstNumber = secondNumber;
            secondNumber = temp;
            }
            
        }
    }
}
