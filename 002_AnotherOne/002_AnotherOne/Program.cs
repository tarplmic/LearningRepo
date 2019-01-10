using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_AnotherOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
            Console.Beep();
            Console.SetWindowSize(105, 30);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("hi");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("hi)");
            Console.ReadLine();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("this is background");
            Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("this is foreground color");
            Console.ReadLine();
            
       
        }
    }
}
