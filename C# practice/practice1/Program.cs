using System;

namespace practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01
            /*
            //readline , input is string
            Console.WriteLine("enter your name");
            string name = Console.ReadLine(); //readline input is always string
            Console.WriteLine($"your name is {name}");
            */

            //02
            //read , input is int
            /*
            Console.WriteLine("enter your value");
            int value = Console.Read(); //read input is always int
            Console.WriteLine("your ASCII value is "+value);
            */

            //03
            /*
            //readkey
            Console.WriteLine("Press any key");
            ConsoleKeyInfo Key = Console.ReadKey();
            Console.WriteLine("You just pressed the " + Key.Key + " key");
            */

            //04
            /*
            //write and writeline
            Console.Write("Enter your name : "); //write will place the input cursor next to it
            Console.ReadLine();
            Console.WriteLine("Entre your name : "); //writeline will place the input cursor in the next line
            Console.ReadLine();
            */

            //05
            /*
            //different types of writeline
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Console.Read();
            Console.WriteLine("So, you are " + firstName + " " + lastName + " and your age is " + age);
            Console.WriteLine($"So, you are {firstName} {lastName} and your age is {age}");
            Console.WriteLine("So, you are {0} {1} and your age is {2}" , firstName , lastName , age);
            */

            //06
            /*
            //convert int to string
            Console.WriteLine("enter your value");
            string value =Convert.ToString(Console.Read()); //read input is always int. bt we are using value as string. so we have to convert int read value to string using ToString
            Console.WriteLine("your ASCII value is " + value);
            */

            //07
            /*
            //int
            int a = 1234; //dont have to use ""
            int b = Convert.ToInt32("5678"); //if we use "" the the value is string and we have to convert it
            int c = int.MinValue;
            int d = int.MaxValue;

            Console.WriteLine("An example of int is " + a + " and " + b + ". the minimum value of int is " + c + " and the maximum value of int is " + d );
            Console.WriteLine($"An example of int is {a} and {b}. the minimum value of int is {c} and the maximum value of int is {d}");
            Console.WriteLine("An example of int is {0} and {1}. the minimum value of int is {2} and the maximum value of int is {3}" , a , b , c , d );
            */

            //08
            //post or prefix
            /*
            int i = 3;
            Console.WriteLine(i);   // output : 3
            Console.WriteLine(i++); // output : 3
            Console.WriteLine(i);   // output : 4
            double d = 1.5;
            Console.WriteLine(d);   // output : 1.5
            Console.WriteLine(++d); // output : 2.5
            Console.WriteLine(d); 	// output : 2.5
            */

            //09
            //Arithmetic binary operators
            //If at least one operator is decimal, the result is decimal!
            //% modulo (remainder after division
            /*
            Console.WriteLine(8 + 2);   // output : 10
            Console.WriteLine(8 - 2);   // output : 6
            Console.WriteLine(8 * 2);   // output : 16
            Console.WriteLine(7.0 / 2.0);   // output : 3.5
            Console.WriteLine(7 / 2.0);     // output : 3.5
            Console.WriteLine(7 / 2);   // output : 3 
                                        //integer division: no digits after the decimal point

            //modulo: remainder after integer division
            Console.WriteLine(9 % 2); 	// output : 1 --> 7/2 = 3 => 7-(2 * 3) = 1
            */

            //10
            //Birth year
            /*
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int intAge = Convert.ToInt32(age); //convert
            int year =DateTime.Now.Year - intAge;
            Console.WriteLine("Birth year: " + year);
            */

            //11
            //



            Console.WriteLine(10 < 12);














            // 
            // Char number =Convert(Console.ReadLine());

            // Console.WriteLine(number);



        }
    }
}
