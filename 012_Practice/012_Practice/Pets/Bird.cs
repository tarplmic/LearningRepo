using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Practice.Pets
{
    class Bird
    {
        public static void BirdMethod()
        {
            Console.Clear();
            Console.WriteLine("What is your bird's name?:");
            string nameAnswer = Console.ReadLine();

            Console.WriteLine("Is your bird a boy or a girl?:");
            string genderAnswer = Console.ReadLine();
            Console.Clear();

            string heShePronouns = DeterminingHeShePronous(genderAnswer);
            string hisHerPronouns = DeterminingHisHerPronous(genderAnswer);

            Console.WriteLine("...");
            Console.WriteLine("One day, " + nameAnswer + " flew out of an open window. " + nameAnswer + " picked up some nice ribbon from Michaels and reutrned home to " +
                hisHerPronouns + " owner. " + nameAnswer + "'s owner was very proud of what " + heShePronouns + " had done.");
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
