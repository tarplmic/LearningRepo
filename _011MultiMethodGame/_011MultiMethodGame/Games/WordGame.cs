using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011MultiMethodGame.Games
{
    class WordGame
    {
        public static void StartWordGame()
        {
            Console.Clear();
            Console.WriteLine("Rearrange the letters in each line to make a word. " +
                "Type 'quit' when you are finished with the game.");

            bool continueWithGame;
            continueWithGame = AnswerReception("four");
            if (continueWithGame)
            {
                continueWithGame = AnswerReception("house");

                if (continueWithGame)
                {
                    continueWithGame = AnswerReception("grapes");

                    if (continueWithGame)
                    {
                        continueWithGame = AnswerReception("logical");

                        if (continueWithGame)
                        {
                            continueWithGame = AnswerReception("computer");
                            if (continueWithGame)
                            {
                                continueWithGame = AnswerReception("theatre");
                            }
                        }
                    }
                }
            }

            bool completedGame = continueWithGame;

            if (completedGame)
            {
                Console.WriteLine("Good Job! You finished the game.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("See ya later then.");
                Console.ReadLine();
            }
        }

        private static bool AnswerReception(string message)
        {
            bool choseToContinue = true;

            bool keepGoing = true;
            while (keepGoing == true)
            {
                WriteJumbledWord(message);
                string answer = Console.ReadLine();

                if (answer == message)
                {
                    CorrectAnswer(answer);
                    keepGoing = false;
                }
                else if (answer == "quit")
                {
                    choseToContinue = false;
                    keepGoing = false;
                }
                else
                {
                    IncorrectAnser(answer);
                }
            }

            return choseToContinue;
        }

        private static string WriteJumbledWord(string message)
        {
            char[] messageCharArray = message.ToCharArray();
            if (messageCharArray.Length == 4)
            {
                Console.Write(messageCharArray[2]);
                Console.Write(messageCharArray[0]);
                Console.Write(messageCharArray[3]);
                Console.Write(messageCharArray[1]);
                Console.Write(" : ");
            }
            else if (messageCharArray.Length == 5)
            {
                Console.Write(messageCharArray[2]);
                Console.Write(messageCharArray[0]);
                Console.Write(messageCharArray[3]);
                Console.Write(messageCharArray[1]);
                Console.Write(messageCharArray[4]);
                Console.Write(" : ");
            }
            else if (messageCharArray.Length == 6)
            {
                Console.Write(messageCharArray[2]);
                Console.Write(messageCharArray[0]);
                Console.Write(messageCharArray[3]);
                Console.Write(messageCharArray[1]);
                Console.Write(messageCharArray[5]);
                Console.Write(messageCharArray[4]);
                Console.Write(" : ");
            }
            else if (messageCharArray.Length == 7)
            {
                Console.Write(messageCharArray[2]);
                Console.Write(messageCharArray[0]);
                Console.Write(messageCharArray[3]);
                Console.Write(messageCharArray[1]);
                Console.Write(messageCharArray[6]);
                Console.Write(messageCharArray[5]);
                Console.Write(messageCharArray[4]);
                Console.Write(" : ");
            }
            else if (messageCharArray.Length == 8)
            {
                Console.Write(messageCharArray[2]);
                Console.Write(messageCharArray[0]);
                Console.Write(messageCharArray[3]);
                Console.Write(messageCharArray[1]);
                Console.Write(messageCharArray[7]);
                Console.Write(messageCharArray[5]);
                Console.Write(messageCharArray[4]);
                Console.Write(messageCharArray[6]);
                Console.Write(" : ");
            }
            return message;
        }

        private static void CorrectAnswer(string answer)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Good Job");
            Console.ResetColor();
            Console.ReadLine();
        }

        private static void IncorrectAnser(string answer)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
