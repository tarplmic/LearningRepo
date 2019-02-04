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
                Colors();
                return true;
            }
            else if (optionChoice == "2")
            {
                Math();
                return true;
            }
            else if (optionChoice == "3")
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

        private static void Colors()
        {
            Console.Clear();
            Console.WriteLine("Type 'quit' when you are finished with the game");
            bool keepGoing = true;

            while (keepGoing == true)
            {
                Console.Write("What is your favorite color:");
                bool showFinalText = true;
                string Answer = Console.ReadLine();

                if (Answer == "blue")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else if (Answer == "red")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else if (Answer == "yellow")
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else if (Answer == "white")
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else if (Answer == "green")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else if (Answer == "purple")
                {
                    Console.WriteLine("I'm sorry. I don't know that color. Restart program and try using 'magenta'");
                    Console.ReadLine();
                    showFinalText = false;
                }
                else if (Answer == "magenta")
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                }
                else if (Answer == "quit")
                {
                    keepGoing = false;
                    showFinalText = false;
                    Console.WriteLine("Ok, see ya later");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("I'm sorry. I don't know that color.");
                    Console.ReadLine();
                    showFinalText = false;
                }

                if (showFinalText == true)
                {
                    Console.WriteLine("Here ya go.");
                    Console.ReadLine();
                }
                Console.ResetColor();
            }
        }

        private static void Math()
        {
            Console.Clear();
            Console.WriteLine("Type 'quit' when you are finished with the game");

            int z = 5;
            bool keepGoing = true;
            bool completedGame = true;
            for (int y = 1; y < 6 && keepGoing == true; y++)
            {
                for (int x = 0; x < z;)
                {
                    Console.WriteLine("What is " + x + "+" + y + ":");

                    string input = Console.ReadLine();
                    int inputAsInt;
                    bool isNum = int.TryParse(input, out inputAsInt);

                    if (input == "quit")
                    {
                        Console.WriteLine("Okay, bye.");
                        Console.ReadLine();
                        keepGoing = false;
                        completedGame = false;
                        break;
                    }
                    if (isNum == false)
                    {
                        Console.WriteLine("Please type a whole number.");
                        Console.ReadLine();
                        continue;
                    }

                    if (inputAsInt == x + y)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        x = x + y;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect");
                    }

                    Console.ResetColor();
                }
                z = z + 5;
            }
            if (completedGame == true)
            {
                Console.WriteLine("Good Job! You finished the game.");
                Console.ReadLine();
            }
        }

        //from here
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

        //to here is all for Word choice
    }
}