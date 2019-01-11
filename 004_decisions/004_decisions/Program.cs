using System;

namespace _004_decisions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           
            {
                /*Console.WriteLine("Michaela's Big Giveaway");
                Console.Write("Choose a door: 1, 2, or 3:");
                string doorAnswer = Console.ReadLine();
                string message;

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
                Console.ReadLine();

                string message = (doorAnswer == "1") ? "boat" : "poop";
                Console.WriteLine("You entered: {0}, therefore you won a {1}.", doorAnswer, message);
                Console.ReadLine();*/


                Console.WriteLine("Type 'quit' when you are finished with the game");
                bool keepGoing = true;

                while (keepGoing == true)
                {
                    
                    Console.Write("What is your favorite color:");
                    bool showFinalText = true;
                    string Answer = Console.ReadLine();


                    if (Answer == "blue")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else if (Answer == "red")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    else if (Answer == "yellow")
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    else if (Answer == "white")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else if (Answer == "green")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (Answer == "purple")
                    {
                        Console.WriteLine("I'm sorry. I don't know that color. Restart program and try using 'magenta'");
                        Console.ReadLine();
                        showFinalText = false;
                    }
                    else if (Answer == "magenta")
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                    }
                    else if (Answer == "quit")
                    {
                        keepGoing = false;
                        showFinalText = false; 
                        Console.WriteLine("Ok, see ya later");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry. I don't know that color.");
                        Console.ReadLine();
                        showFinalText = false;
                    }

                    if (showFinalText == true)
                    {
                        Console.WriteLine("Here ya go.");
                        Console.ReadLine();

                    }
                    Console.ResetColor();


                }
                 
            }
        }
    }
}