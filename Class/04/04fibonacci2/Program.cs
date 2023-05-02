using System;

namespace _04fibonacci2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             int length = Convert.ToInt32(Console.ReadLine());

            int firstNumber = 1;
            int secondNumber = 1;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            int temp;

            for (int i = 0; i < length - 2; i++)
            {
                temp = firstNumber + secondNumber;
                Console.WriteLine(temp);
                firstNumber = secondNumber;
                secondNumber = temp;
            }
            */


            /*
            int number = Convert.ToInt32(Console.ReadLine());

            int firstNumber = 1;
            int secondNumber = 1;
            int temp = 0;
            
            for (int i = 0; i < number-2; i++)
            {
                temp = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
            }
            Console.WriteLine(temp);
            
            */

            
            
            int input = Convert.ToInt32(Console.ReadLine());

            int firstNumber = 1;
            int secondNumber = 1;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);

            int temp = ( firstNumber+secondNumber);
            
            while (temp < input)
            {
                firstNumber = secondNumber;
                secondNumber = temp;
                Console.WriteLine(temp);
                temp = firstNumber + secondNumber;
                
            }
            

            /*
            int input = Convert.ToInt32(Console.ReadLine());

            int firstNumber = 1;
            int secondNumber = 1;
            int temp = (firstNumber + secondNumber);

            while (temp < input)
            {
                firstNumber = secondNumber;
                
                secondNumber = temp;
                
                temp = firstNumber + secondNumber;

            }
            Console.WriteLine(secondNumber);

            Console.ReadLine();
            */
            

        }
    }
}
