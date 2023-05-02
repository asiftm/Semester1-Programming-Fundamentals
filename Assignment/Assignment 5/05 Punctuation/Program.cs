using System;

namespace Punctuation
{
    internal class Program
    {
        static void Main(string[] args)
        {   //reading an input
            string input = Console.ReadLine();

            //empty variable to store output
            string result = string.Empty;

            for(int i=0; i<input.Length;i++)
            {   
                //making each string value a char
                char ch = input[i];

                //checking if a char are punctuation or not
                if(( ch >= '!' && ch <= '/')||(ch >= ':' && ch <= '@') || (ch >= '[' && ch <= '`') || (ch >= '{' && ch <= '~'))
                {   
                    //checking they are repeating or not...if the the char is same as previous one or not
                    if (!(input[i - 1] == input[i]))
                    {   
                        //storing in result variable
                        result += ch;
                    }
                }
                //a non-punctuation char,directly storing into the result variable
                else
                {
                    result += ch;
                }
            }

            Console.WriteLine(result);
        }
    }
}
