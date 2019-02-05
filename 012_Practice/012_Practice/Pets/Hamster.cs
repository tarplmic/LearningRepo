using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Practice.Pets
{
    class Hamster
    {
        public static void HamsterMethod()
        {
            Console.Clear();
            Console.WriteLine("What is your hamster's name?:");
            string nameAnswer = Console.ReadLine();

            Console.WriteLine("Is your hamster a boy or a girl?:");
            string genderAnswer = Console.ReadLine();
            Console.Clear();

            string heShePronouns = DeterminingHeShePronous(genderAnswer);
            string hisHerPronouns = DeterminingHisHerPronous(genderAnswer);

            Console.WriteLine("...");
            Console.WriteLine("One day, " + nameAnswer + " crawled out of " + hisHerPronouns + " cage. " + nameAnswer +  " was finally free!");
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
