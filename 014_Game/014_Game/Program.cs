using System;

namespace _014_Game
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Michaela's Pet Shoppe. Which animal do " +
                "you want to visit today?");
            Console.ReadLine();
            bool keepDisplayingPetMenu = true;
            while (keepDisplayingPetMenu == true)
            {
                DisplayPetMenu();
                keepDisplayingPetMenu = GetPetAnswer(); 
            }
        }

        private static void DisplayPetMenu()
        {
            Console.WriteLine("Pets Available: ");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Bird");
            Console.WriteLine("3. Bunny");
            Console.WriteLine("4. Pig");
            Console.WriteLine("5. Fishies");
            
        }

        private static bool GetPetAnswer()
        {
            Console.Write("Number of your choice: ");
            string petAnswer = Console.ReadLine();
            if (petAnswer == "1")
            {
                Cat.Cats();
            }
            else if (petAnswer == "2")
            {
                Bird.Dogs();
            }
            else if (petAnswer == "3")
            {
                Bunny.Bunnies();
            }
            else if (petAnswer == "4")
            {
                Pig.Pigs();
            }
            else if (petAnswer == "5")
            {
                Fish.Fishes();
            }
            else if (petAnswer == "quit")
            {
                return false; 
            }
            else
            {
                Console.WriteLine("That is an invalid option. " +
                    "Try typing the number like this, \"1\" or \"2\".");
                Console.ReadLine();
            }
            Console.Clear();
            return true; 
        }
    }
}