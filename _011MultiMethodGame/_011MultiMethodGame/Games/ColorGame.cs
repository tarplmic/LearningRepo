using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011MultiMethodGame.Games
{
    class ColorGame
    {
        public static void Colors()
        {
            Console.Clear();
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
