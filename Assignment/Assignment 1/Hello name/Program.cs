/*
01 Hello Name (test codegrade)

Read the name and surname of a person and say 'Hello' to them.

Input/Output
input:
Elke
Boonen
output:
Hello Elke Boonen

input:
Tristan
Vandevelde
output:
Hello Tristan Vandevelde
*/

using System;


namespace Hello_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName=Console.ReadLine();
            string lastName=Console.ReadLine();

            Console.WriteLine("Hello " +firstName+" "+lastName);
        }
    }
}