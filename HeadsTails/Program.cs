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
            Console.WriteLine("Do you want to try again?");
            Console.WriteLine("'yes' or 'no'");
            string choice = Console.ReadLine();
            if(choice == "yes")
            {
                TossACoin();
            }
            else { Console.WriteLine("Thanks you for cooperation"); }
        }
        static void ConditionsKey()
        {
            Console.WriteLine("What i have to do now?");
            Console.WriteLine("'draw' or 'quit'");
            string decision = Console.ReadLine();
            if (decision == "draw")
            {
                TossACoin();
            }
            else if (decision == "quit") 
            {
                Console.WriteLine("Thanks you for cooperation");
            }
            else
            {
                Console.WriteLine("You choosed wrong command, try again");
                ConditionsKey();
            }
        }


    }
}
