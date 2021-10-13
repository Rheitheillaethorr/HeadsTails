using System;

namespace HeadsTails
{
    class Program
    {
        static void Main(string[] args)
        {
            ConditionsKey();


        }
        static void TossACoin()
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(2);
            if(RandomNumber == 0)
            {
                Console.WriteLine("You drew HEADS"); 
            }
            else
            {
                Console.WriteLine("You drew TAILS");
            }
        }
        static void ConditionsKey()
        {
            Console.WriteLine("Press 'Enter' to flip a coin or 'Tab' to quit!");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                TossACoin();
            }
            else if (Console.ReadKey().Key != ConsoleKey.Enter) 
            {
                Console.WriteLine("You choosed wrong Key, try again");

            }
            else{}
        }


    }
}
