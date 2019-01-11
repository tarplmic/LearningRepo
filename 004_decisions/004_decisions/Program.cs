using System;

namespace _004_decisions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           
            {
                Console.WriteLine("Michaela's Big Giveaway");
                Console.Write("Choose a door: 1, 2, or 3:");
                string doorAnswer = Console.ReadLine();
                /*string message;

                if (doorAnswer == "1")
                {
                    message = "You won a new car!";
                }
                else if (doorAnswer == "2")
                {
                    message = "Yow won a new boat!";
                }
                else if (doorAnswer == "3")
                {
                    message = "You won a new cat!";
                }
                else
                {
                    message = "Sorry, I didn't understand that.";
                }

                Console.Write(message);
                Console.ReadLine(); */

                string message = (doorAnswer == "1") ? "boat" : "poop";
                Console.WriteLine("You entered: {0}, therefore you won a {1}.", doorAnswer, message);
                Console.ReadLine();
            }
        }
    }
}