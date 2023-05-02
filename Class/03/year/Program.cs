namespace year
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("age?");
            int age=Convert.ToInt32(Console.ReadLine());

            if (age < 16) 
                Console.WriteLine("No alcohol");

            else if (age >= 18)
                Console.WriteLine("Spirits");

            else
                Console.WriteLine("Beer");

            Console.WriteLine(" The \n end ");
        }
    }
}