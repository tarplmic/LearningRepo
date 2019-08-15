using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

            Car newCar = new Car();
            newCar.Make = "Honda";
            newCar.Model = "Civic";
            newCar.Year = 2018;
            newCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}",
                newCar.Make,
                newCar.Model,
                newCar.Year,
                newCar.Color);
            Console.WriteLine("{0:C}", newCar.DetermineMarketValue());

            Console.ReadLine();
        }

       /* private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;

            return carValue;
        }*/
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
       
        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;
            return carValue;
        }
    }
}
