using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011MultiMethodGame.Games
{
    class MathGame
    {
        public static void Math()
        {
            Console.Clear();
            Console.WriteLine("Type 'quit' when you are finished with the game");

            int z = 5;
            bool keepGoing = true;
            bool completedGame = true;
            for (int y = 1; y < 6 && keepGoing == true; y++)
            {
                for (int x = 0; x < z;)
                {
                    Console.WriteLine("What is " + x + "+" + y + ":");

                    string input = Console.ReadLine();
                    int inputAsInt;
                    bool isNum = int.TryParse(input, out inputAsInt);

                    if (input == "quit")
                    {
                        Console.WriteLine("Okay, bye.");
                        Console.ReadLine();
                        keepGoing = false;
                        completedGame = false;
                        break;
                    }
                    if (isNum == false)
                    {
                        Console.WriteLine("Please type a whole number.");
                        Console.ReadLine();
                        continue;
                    }

                    if (inputAsInt == x + y)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        x = x + y;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect");
                    }

                    Console.ResetColor();
                }
                z = z + 5;
            }
            if (completedGame == true)
            {
                Console.WriteLine("Good Job! You finished the game.");
                Console.ReadLine();
            }
        }
    }
}
