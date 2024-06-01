namespace NkrumHub
{
    class program
    {
        public static void Main(string[] args)
        {
            int age;
            float ticketprice;

            Console.WriteLine("Welcome to my Ticket Price Calculator App! I hope you enjoy");
            Console.WriteLine("Kindly input your age");

            age= Convert.ToInt32(Console.ReadLine());

            if (age >65 || age<=12) 
            {
                Console.WriteLine("Your ticket is at a discounted price of GHC 7");

            }

            else
            {
                Console.WriteLine("Your ticket costs GHC 10");
            }


        }
    }
}