using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            Console.WriteLine(x + 2);
            Console.ReadLine();
            Console.WriteLine(x + 3);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");
            Console.Write("Type your first name:");
            string firstName = Console.ReadLine();

            Console.Write("Type your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello, " + firstName + " " + lastName);
            Console.ReadLine();

        }
    }
}
