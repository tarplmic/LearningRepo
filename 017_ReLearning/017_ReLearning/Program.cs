using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_ReLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello blah blah blah " +
                "blah blah blah");
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
            Console.WriteLine("chose");
            string PetAnswer = Console.ReadLine();

            if (PetAnswer == "1")
            {
                Cat.Cats();
            }
            else if (PetAnswer == "2")
            {
                Bunny.Bunnies();
            }
            else if (PetAnswer == "quit")
            {
                return false;
            }
            else
            {
                Console.WriteLine("You cant dco that");
            }
            Console.Clear();
            return true;
        }
    }
}
