using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Name");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello, " + name);
            

            if (hours > 8)
            {
                Console.WriteLine("you are well rested");

            }
            else
            {
                Console.WriteLine("you need more sleep");
            }
            Console.ReadLine();
        }
    }
}
