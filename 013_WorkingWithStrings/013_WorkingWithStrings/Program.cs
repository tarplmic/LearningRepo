using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. This is a test run for the idiot developer Michaela. She has forgotten " +
                "how to program entinerely!");
            Console.ReadLine();
            bool keepAskingOptionChoice = true;
            while (keepAskingOptionChoice)
            {
                Console.Clear();
                Console.WriteLine("Chose an option of a test method created by Michaela; type the number of your option, " +
                    "or type quit when finished with the program.");
                Console.WriteLine("Option 1: For Iteration");
                Console.WriteLine("Option 2: Method Practice");
                string optionChoice = Console.ReadLine();
                if (optionChoice == "1")
                {
                    OtherMethods.ForIteration.For();
                }
                else if (optionChoice == "2")
                {
                    OtherMethods.MethodPractice.Method();
                }
                else if (optionChoice == "quit")
                {
                    keepAskingOptionChoice = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please try typing the number \"1\", \"2\", or \"quit\"");
                    Console.ReadLine();
                }
            }
   
        }
    }
}
