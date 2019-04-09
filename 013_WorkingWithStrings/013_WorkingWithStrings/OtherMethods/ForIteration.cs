using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_WorkingWithStrings.OtherMethods
{
    class ForIteration
    {
        public static void For()
            {
            Console.Clear();
            string word = "Albaricoque";
            char[] wordCharArray = word.ToCharArray();
           
                for (int i = 0; i < wordCharArray.Length; i++)
                {
                    Console.WriteLine(wordCharArray[i]);
                    Console.ReadLine();
                }
            }
    }
}
