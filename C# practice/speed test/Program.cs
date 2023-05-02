using System;

namespace speed_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the speed limit : ");
            int speedLimit =int.Parse(Console.ReadLine());

            Console.WriteLine("enter the speed : ");
            int speed = int.Parse(Console.ReadLine());

            int demerit = 0;

            if (speedLimit > speed)
            {
                Console.WriteLine("youre good to go");
            }
            else
            {
                int diff = speed - speedLimit;

                demerit = (diff/5);
                if(demerit<12)
                {
                    Console.WriteLine("your demerit point is : "+demerit);
                }
                else
                {
                    Console.WriteLine("your licence is cancelled");
                }
                
            }
            
        }
    }
}
