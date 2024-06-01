namespace NkrumHub
{
    class program
    {
        public static void Main(string[] args)
        {

            float breadth;
            float height;
            float width;


            Console.WriteLine("Welcome to my Triangle type identifier app. I hope you love this one.");

            Console.WriteLine("Please enter the breadth of your triangle");
            breadth=Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please enter the height of your triangle");
            height =Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please enter the width of your triangle");
            width =Convert.ToSingle(Console.ReadLine());    


            if (breadth==height && height == width)
            {
                Console.WriteLine("Your triangle is an Equilateral triangle");

            }
            
            else if (breadth!=height && height != width && width!=breadth) 
            {
                Console.WriteLine("Your triangle is an Scalene Triangle ");
            }

            else
            {
                Console.WriteLine("Your triangle is an Isosceles triangle");
            }










        }  
    }
}