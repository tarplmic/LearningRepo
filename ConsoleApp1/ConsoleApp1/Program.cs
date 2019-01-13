using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string zig = ("Listen to the breeze, whisper to me please," + 
                           "don't send me on the path of nevermore.");
            char[] zigCharArray = zig.ToCharArray();
            Array.Reverse(zigCharArray);

            foreach (char zigChar in zigCharArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
              

            /*int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();  
            string mark = "mark";
            string[] names = new string[] { "eddie", "alex", "lewis", mark };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
                
            }
                Console.ReadLine(); 

            foreach (string name in names)
            {
                if (name == mark)
                {
                    Console.WriteLine(name + ", that is a stupid name");
                }
                else  
                {
                    Console.WriteLine(name);
                }
               
            }
            Console.ReadLine(); */
        }
    }
}
