using System;

namespace _018_ReLearningTwo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool keepDisplayingOptionMenu = true;
            while (keepDisplayingOptionMenu == true)
            {
                DisplayMenu();
                keepDisplayingOptionMenu = GetMenuAnswer();
            }
            
        }
        private static void DisplayMenu()
        {
            Console.WriteLine("You walk into a pile of poop. What do you do?");
            Console.WriteLine("1. Scream for your cat to come rescue you");
            Console.WriteLine("2. Start munching to free yourself");
            Console.WriteLine("3. Mentally kill Victoria for leaving the pile there");
            Console.WriteLine(". . .");
            Console.WriteLine("4. Woosy out and quit the game");
        }
        private static bool GetMenuAnswer()
        {
            string optionAnswer = Console.ReadLine();
            Console.Clear();

            if (optionAnswer == "1")
            {
                Option_1.Scream();
            }
            else if (optionAnswer == "2")
            {
                Option_2.Munch();
            }
            else if (optionAnswer == "3")
            {
                Option_3.Victoria();
            }
            else if (optionAnswer == "4")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Whaaat");
                Console.ReadLine();
            }
            Console.Clear();
            return true;
        }
    }
}