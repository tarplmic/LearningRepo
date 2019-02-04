using System;

namespace _011MultiMethodGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool showMainMenu = true;
            while (showMainMenu)
            {
                showMainMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Colors");
            Console.WriteLine("2) Math");
            Console.WriteLine("3) Words");
            Console.WriteLine("4) Quit");
            Console.Write("Your choice: ");
            string optionChoice = Console.ReadLine();

            if (optionChoice == "1")
            {
                Games.ColorGame.Colors();
                return true;
            }
            else if (optionChoice == "2")
            {
                Games.MathGame.Math();
                return true;
            }
            else if (optionChoice == "3")
            {
                Games.WordGame.StartWordGame();
                return true;
            }

            else if (optionChoice == "4")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}