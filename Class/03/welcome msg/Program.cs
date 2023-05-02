namespace welcome_msg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is you age?");
            int age=Convert.ToInt32(Console.ReadLine());

            /*

            if (age == 18)
            {
                Console.WriteLine("allowed to do crimes");
            }
            else if (age == 19)
            {
                Console.WriteLine("midlife crisis");
            }
            else if (age == 20)
            {
                Console.WriteLine("my 20 reasons why");
            }
            else if (age == 21)
            {
                Console.WriteLine("can marry");
            }
            else if (age == 22)
            {
                Console.WriteLine("leonardo de caprio approves");
            }
            else if (age == 23)
            {
                Console.WriteLine("new life");
            }
            else if (age == 24)
            {
                Console.WriteLine("going smooth");
            }
            else if (age == 25)
            {
                Console.WriteLine("kids calling me gramps");
            }
            else if (age == 26)
            {
                Console.WriteLine("expiry date");
            }
            */

            switch (age)
            {
                case 18: Console.WriteLine("allowed to do crimes");
                    break;
                case 19: Console.WriteLine("midlife crisis");
                    break;
                case 20: Console.WriteLine("my 20 reasons why");
                    break;
                case 21: Console.WriteLine("can marry");
                    break;
                case 22: Console.WriteLine("leonardo de caprio approves");
                    break;
                case 23: Console.WriteLine("new life");
                    break;
                case 24: Console.WriteLine("going smooth");
                    break;
                case 25: Console.WriteLine("kids calling me gramps");
                    break;
                case 26: Console.WriteLine("expiry date");
                    break;
                default: Console.WriteLine("no special call");
                    break;
                

            }
        }
    }
}