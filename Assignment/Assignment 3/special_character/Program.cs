using System;
using System.Reflection.Metadata;

namespace special_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char number1 = Convert.ToChar(Console.ReadLine());
            
            int number2 = (int)(number1);
            

            if ( number2 >32 && number2 < 48 || number2>57 && number2< 65 || number2>90 && number2<96 || number2>122 && number2<127)
            {
                Console.WriteLine("special character");
            }
            else if ( number2 > 47 && number2 <58)
            {
                Console.WriteLine("digit");
            }
            else if (number2 == 65|| number2 == 69 || number2 == 73 || number2 == 79 || number2 == 85 || number2 == 97 || number2 == 101 || number2 == 105 || number2 == 111 || number2 == 117 )
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }






        }
    }
}
