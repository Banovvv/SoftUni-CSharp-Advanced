using _04.PizzaCalories.Models;
using System;

namespace _04.PizzaCalories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaArgs = Console.ReadLine().Split();
            string[] doughArgs = Console.ReadLine().Split();

            string flourType = doughArgs[1];
            string bakingTehnique = doughArgs[2];
            double weight = double.Parse(doughArgs[3]);

            try
            {
                Dough dough = new Dough(flourType, bakingTehnique, weight);
                Pizza pizza = new Pizza(pizzaArgs[1], dough);

                while (true)
                {
                    string command = Console.ReadLine();

                    if (command == "END")
                    {
                        break;
                    }

                    string[] toppingArgs = command.Split();

                    string toppingName = toppingArgs[1];
                    double toppingWeight = double.Parse(toppingArgs[2]);

                    pizza.AddTopping(new Topping(toppingName, toppingWeight));
                }

                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
