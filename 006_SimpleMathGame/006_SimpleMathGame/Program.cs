using System;

namespace _006_SimpleMathGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int z = 5;
            bool keepGoing = true;
            for (int y = 1; y < 100 && keepGoing == true; y++)
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
                    Console.ReadLine();


                }
                
                z = z + 5;
            }

            /*Console.WriteLine("What is " + x + "+1: ");

            int Answer = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < 5;)
            {
                if (Answer == x + 1)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    x = x + 1;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect");
                }
            }

            for (int x = 0; x < 10;)
            {
                Console.WriteLine("What is " + x + "+2: ");
                int Answer = Convert.ToInt32(Console.ReadLine());

                if (Answer == x + 2)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    x = x + 2;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect");
                }

                Console.ResetColor();
                Console.ReadLine();
            } */

            /*
                bool functionOnePlusOne = true;
                while (functionOnePlusOne = true)
                {
                    Console.WriteLine("What is 1+1: ");
                    string Answer = Console.ReadLine();

                    if (Answer == "2")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorrect");
                    }
                }
                Console.ReadLine();
                Console.ResetColor();

            bool functionTwoPlusOne = true;
            while (functionTwoPlusOne = true)
            {
                Console.WriteLine("What is 2+1: ");
                string Answer = Console.ReadLine();

                if (Answer == "3")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect");
                }
            }
            Console.ReadLine();
            Console.ResetColor();

            Console.WriteLine("next code");
            Console.ReadLine();
            */
        }
    }
}