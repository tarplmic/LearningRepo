using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_TestingOutClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            FoodOptions food1 = new FoodOptions();
            food1.nameOfFood = "spaghetti";
            food1.cookTimeInMinutes = 20;
            food1.tasteLevel = "delicious";
            food1.ingredients = "pasta, spaghetti sauce, and parmesean";

            Console.WriteLine("I have chosen to make you {0}. It will take around {1} " +
                "minutes, and you will need {2}. It will be {3}.",
                food1.nameOfFood,
                food1.cookTimeInMinutes,
                food1.ingredients,
                food1.tasteLevel);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Now, it is your turn to chose a dish to make for me. " +
                "Answer the following questions:");
            Console.WriteLine("Name of food: ");
            string userNameOfFood = Console.ReadLine();
            Console.WriteLine("Cook time in minutes: ");
            int userCookTimeInMinutes;
            int.TryParse(Console.ReadLine(), out userCookTimeInMinutes);
            Console.WriteLine("Ingredients: ");
            string userIngredients = Console.ReadLine();
            Console.WriteLine("Describe the taste of this dish: ");
            string userTasteLevel = Console.ReadLine();


            FoodOptions food2 = new FoodOptions();
            food2.nameOfFood = userNameOfFood;
            food2.cookTimeInMinutes = userCookTimeInMinutes;
            food2.ingredients = userIngredients;
            food2.tasteLevel = userTasteLevel;
            Console.WriteLine("You have chosen to make me {0}. It will take around {1} " +
                "minutes, and you will need {2}. It will be {3}.",
                food2.nameOfFood,
                food2.cookTimeInMinutes,
                food2.ingredients,
                food2.tasteLevel);
            Console.ReadLine();
        }  
    }
    class FoodOptions
    {
        public string nameOfFood { get; set; }
        public int cookTimeInMinutes { get; set; }
        public string tasteLevel { get; set; }
        public string ingredients { get; set; }
    }
}
