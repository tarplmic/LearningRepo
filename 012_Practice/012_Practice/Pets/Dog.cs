using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Practice.Pets
{
    class Dog
    {
        public static void DogMethod()
        {
            Console.Clear();
            Console.WriteLine("What is your dog's name?:");
            string nameAnswer = Console.ReadLine();

            Console.WriteLine("Is your dog a boy or a girl?:");
            string genderAnswer = Console.ReadLine();
            Console.Clear();

            string heShePronouns = DeterminingHeShePronous(genderAnswer);
            string hisHerPronouns = DeterminingHisHerPronous(genderAnswer);

            Console.WriteLine("...");
            Console.WriteLine("One day, " + nameAnswer + " was looking for " + hisHerPronouns + " owner, when " + heShePronouns + " came across a shiny ball. " +
                nameAnswer + " picked the ball up in " + hisHerPronouns + " mouth, and ran off happily to " + hisHerPronouns + " owner.");
        }

        private static string DeterminingHeShePronous (string genderAnswer)
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

        private static string DeterminingHisHerPronous(string genderAnswer)
        {
            string pronoun = "his";

            if (genderAnswer.ToLower() == "boy")
            {
                pronoun = "his";
            }
            else if (genderAnswer.ToLower() == "girl")
            {
                pronoun = "her";
            }

            return pronoun;
        }



    }
}
