using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_MessingAround
{
    class Program
    {
        static void Main(string[] args)
        {
           

            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    
                }
                else
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }

            

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);


            }
            Console.ReadLine();
           

          
        }

    }
}
