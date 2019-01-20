using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string Philip = "Philip";
            ReverseStringandPrint("Michaela");
            ReverseStringandPrint("Victoria");
            ReverseStringandPrint("Brianna");
            ReverseStringandPrint(Philip);

        }

        private static void ReverseStringandPrint(string message)
        {
            Console.WriteLine(ReverseString(message));
            Console.ReadLine();
        }
        
        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            return String.Concat(messageArray);
        }
        
    }
}
