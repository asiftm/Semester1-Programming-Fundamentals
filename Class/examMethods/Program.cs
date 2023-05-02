using System;

namespace examMethods
{
    internal class Program
    {

        static void question1(int[] inputArray1)
        {
            int value = 0;

            for (int i = inputArray1.Length-1; i >=0 ; i--)
            {
                value = inputArray1[i];
                Console.WriteLine(value);
            }
            //return value;
            
        }
        static int question2(int[] inputArrat2)
        {
            int highest = inputArrat2[0];

            for (int i = 0; i < inputArrat2.Length-1; i++)
            {
                if (inputArrat2[i] > inputArrat2[i+1])
                {
                    highest = inputArrat2[i];
                }
                else
                {
                    highest = inputArrat2[i+1];
                }
            }
           
           // Console.WriteLine(highest);
            return highest;
        }

        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 1, 2, 3 };

            string question = Console.ReadLine();

            switch (question)
            {
                case "A":    
                         question1(array1);
                         //Console.WriteLine(question1);
                         break;
                case "B":
                         int highest = question2(array2);
                         Console.WriteLine(highest);
                         break;
                default : Console.WriteLine("no match");
                    break;
            }
        }
    }
}
