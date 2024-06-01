namespace NkrumHub
{
    class program
    {
        public static void Main(string[] args)
        {

            int score;
            Console.WriteLine("Welcome to my Grade Calculator App");
            Console.WriteLine("To begin, kindly enter your score from 0-100");

            score=Convert.ToInt32(Console.ReadLine());

            while (score < 101)
            {
                if (score >= 90)
                {
                    Console.WriteLine("Your grade is A");
                    break;
                }

                else if (score >= 80 && score <= 89)
                {
                    Console.WriteLine("Your grade is B");
                    break;
                }


                else if (score >= 70 && score < 79)
                {
                    Console.WriteLine("Your grade is C");
                    break;
                }

                else if (score >= 60 && score < 69)
                {
                    Console.WriteLine("Your grade is D");
                    break;

                }

                else
                {
                    Console.WriteLine("Your grade is F");
                    break;
                }

                 Console.WriteLine("Please enter a number between 0-100");
            score = Convert.ToInt32(Console.ReadLine());

            }

           

            Console.WriteLine("Thank you for using my app. Stay tuned for more improvements. ");
            Console.ReadKey();



        }
    }
}