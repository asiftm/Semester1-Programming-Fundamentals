namespace formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age = Convert.ToInt32(Console.ReadLine()); 
            int age;

            string input = Console.ReadLine();
            bool success = Int32.TryParse(input, out age);

           if(success)
            {
                Console.WriteLine($"success! you are {age} years old");
           

                switch (age)    
                {
                    case 18: Console.WriteLine("yay 18");
                        break;
                    default: Console.WriteLine("no message");
                        break;
                 }
                
            }
            else
            {
                Console.WriteLine("sorry couldnt find any result");

                

            }
          
            
        }
    }
}