using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_ClassesAgain
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Civic";
            myCar.Year = 2018;
            myCar.Color = "Grey";

            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year} {myCar.Color}");

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
            Console.ReadLine();
        }
        
    }

    class Car
    {
        public string Make { get; set; } 
        public string Model { get; set;}
        public int Year { get; set; }
        public string Color { get; set; }
        

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (this.Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;
        }
    }


}
