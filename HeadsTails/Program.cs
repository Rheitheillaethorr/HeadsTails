using System;

namespace HeadsTails
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void Rand()
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(0, 1);
            Console.WriteLine("Press 'Enter' to flip a coin or 'q' for quit!");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("draw");
            }
            else if (Console.ReadKey().Key == ConsoleKey.Q) { }
            else
            {
                Console.WriteLine("You choosed wrong letter, try again");
            }
        }

    }
}
