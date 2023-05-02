using System;

namespace sadman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int c = 1;
            int b = 1;

            if(x%2==0 && y%2==0 || x % 2 == 1 && y % 2 == 1)
            {
                int m = (x + y) / 2;

                for (int i = x; i <= m; i++)
                {
                    int a = 2 * i - 1;


                    b = a * c;
                    c = b;
                }
                Console.WriteLine(c);
            }
            else
            {
                int n= (x + y - 1)/2;

                for (int i = x; i <= n; i++)
                {
                    int a = 2 * i - 1;


                    b = a * c;
                    c = b;
                }
                Console.WriteLine(c);
            }
                
               
           

           
            
            
        }
    }
}
