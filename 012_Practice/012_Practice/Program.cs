using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, my name is Michaela. What is your name?:");
            string nameAnswer = Console.ReadLine();
            Console.WriteLine("Hello " + nameAnswer + ". Nice to meet you. Now that we've been acquainted, let's get down to business.");
            Console.ReadLine();

            Console.Clear();

            bool askPetQuestionAgain = true;
            do
            {
                Console.WriteLine("Do you own any pets?");
                string petAnswer = Console.ReadLine();
                if (petAnswer.ToLower() == "no")
                {
                    Console.WriteLine("Okay, moving on.");
                    askPetQuestionAgain = false;
                      
                }
                else if (petAnswer.ToLower() == "yes")
                {
                    AskPetQuestions();
                    askPetQuestionAgain = false;
                }
                else
                {
                    Console.WriteLine("Please answer the question");
                }

            } while (askPetQuestionAgain);

                Console.ReadLine();

        }
        

        private static void AskPetQuestions()
        {
            Console.Clear();
           bool askTypePetQuestionAgain = true;
            do
            {
                Console.WriteLine("Cool! What type of pet do you own?:");
                string typeOfPetAnswer = Console.ReadLine();
                if (typeOfPetAnswer.ToLower() == "dog")
                {
                    Pets.Dog.DogMethod();
                    //askTypePetQuestionAgain = false;
                }
                else if (typeOfPetAnswer.ToLower() == "cat")
                {
                    Pets.Cat.CatMethod();
                    //askTypePetQuestionAgain = false;
                }
                else if (typeOfPetAnswer.ToLower() == "bird")
                {
                    Pets.Bird.BirdMethod();
                    //askTypePetQuestionAgain = false;
                }
                else if (typeOfPetAnswer.ToLower() == "hamster")
                {
                    Pets.Hamster.HamsterMethod();
                    //askTypePetQuestionAgain = false;
                }
                else
                {
                    Console.WriteLine("Try a different animal, or a more generic version of your previous animal.");
                    Console.ReadLine();
                }
                Console.ReadLine();
                Console.Clear();
            } while (askTypePetQuestionAgain);
        }
    }
}
