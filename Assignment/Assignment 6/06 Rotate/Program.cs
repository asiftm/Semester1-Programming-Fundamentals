using System;


namespace Rotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] newArray = input.Split(" ");
            

            int number = Convert.ToInt32(Console.ReadLine());

            string output1 = string.Empty;
            string output2 = string.Empty;

            if( number >= 0 )
            {
                for (int i = 0; i <= newArray.Length; i++)
                {
                    if (i < number)
                    {
                        output1 = output1 + newArray[i] + " ";
                    }
                    else if ((number >= i) && (number < newArray.Length))
                    {
                        output2 = output2 + newArray[number] + " ";
                        number++;
                    }
                }
                Console.WriteLine(output2 + output1);
            }

            else
            {
                int numberPos = number * (-1);

                for (int i = 0; i <= newArray.Length; i++)
                {
                    int num = newArray.Length - numberPos;
                    if(i<num)
                    {
                        output1 = output1 + newArray[i] + " ";
                    }
                    else if(i>num)
                    {
                        for (int j = (newArray.Length-numberPos); j < newArray.Length; j++)
                        {
                            output2 =output2 + newArray[j] + " ";
                        }
                        
                    }
                }
                Console.WriteLine(output2 + output1);   
            }
        }
    }
}
