using System;

namespace _008_JumbledWordGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Rearrange the letters in each line to make a word.");

            bool keepGoingLogical = true;
            while (keepGoingLogical == true)
            {
                string logical = "logical";
                char[] logicalCharArray = logical.ToCharArray();

                Console.Write(logicalCharArray[2]);
                Console.Write(logicalCharArray[0]);
                Console.Write(logicalCharArray[3]);
                Console.Write(logicalCharArray[1]);
                Console.Write(logicalCharArray[6]);
                Console.Write(logicalCharArray[5]);
                Console.Write(logicalCharArray[4]);
                Console.Write(" : ");

                string Answer = Console.ReadLine();

                if (Answer == "logical")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Good Job");
                    Console.ResetColor();
                    Console.ReadLine();
                    keepGoingLogical = false;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect");
                    Console.ResetColor();
                }
            }

            Console.WriteLine("Test");
            Console.ReadLine();
        }
    }
}