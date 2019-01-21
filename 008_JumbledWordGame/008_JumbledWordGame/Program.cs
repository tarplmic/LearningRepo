using System;

namespace _008_JumbledWordGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Rearrange the letters in each line to make a word.");
            AnswerReception("four");
            AnswerReception("house");
            AnswerReception("grapes");
            AnswerReception("logical");
            AnswerReception("computer");
        }


        private static void AnswerReception(string message)
        {
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
                else
                {
                    IncorrectAnser(answer);
                }
            }
        }

        private static string WriteJumbledWord (string message)
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