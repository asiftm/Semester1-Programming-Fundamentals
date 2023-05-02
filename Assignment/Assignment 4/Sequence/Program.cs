using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using System.Linq;
namespace Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char alphabet1 = Convert.ToChar(Console.ReadLine());
            char alphabet2 = Convert.ToChar(Console.ReadLine());


            if (alphabet1 < alphabet2)
            {
                for (char i = alphabet1; i <= alphabet2; i++)
                {
                    if (i >= alphabet1 && i!=65 && i !=69 && i !=73 && i !=79 && i != 85 && i !=97 && i !=101 && i != 105 && i !=111 && i !=117)
                    {
                        Console.Write(i);
                        
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }
        }  
    }
}
