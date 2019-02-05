using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Practice.Pets
{
    class Cat
    {
        public static void CatMethod()
        {
            Console.Clear();
            Console.WriteLine("What is your cat's name?:");
            string nameAnswer = Console.ReadLine();

            Console.WriteLine("Is your cat a boy or a girl?:");
            string genderAnswer = Console.ReadLine();
            Console.Clear();
            
            string heShePronouns = DeterminingHeShePronous(genderAnswer);
            string hisHerPronouns = DeterminingHisHerPronous(genderAnswer);

            Console.WriteLine("...");
            Console.WriteLine("One day, " + nameAnswer + " was walking around the block when " + heShePronouns + " saw a turtle. " +
                nameAnswer + " let the turtle climb on " + hisHerPronouns + " back, and carried it back to " + hisHerPronouns + " owner.");
        }

        private static string DeterminingHeShePronous(string genderAnswer)
        {
            string pronoun = "he";

            if (genderAnswer.ToLower() == "boy")
            {
                pronoun = "he";
            }
            else if (genderAnswer.ToLower() == "girl")
            {
                pronoun = "she";
            }

            return pronoun;
        }

        private static string DeterminingHisHerPronous(string dogGenderAnswer)
        {
            string pronoun = "his";

            if (dogGenderAnswer.ToLower() == "boy")
            {
                pronoun = "his";
            }
            else if (dogGenderAnswer.ToLower() == "girl")
            {
                pronoun = "her";
            }

            return pronoun;
        }
    }
}
