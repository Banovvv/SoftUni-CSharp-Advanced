using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
    public class Program
    {
        static void Main()
        {
            //Peter = 11; George = 4
            //Bread = 10; Milk = 2;
            //Peter Bread
            //George Milk
            //George Milk
            //Peter Milk
            //END

            string[] peopleArgs = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] productsArgs = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();

            foreach (string personArgs in peopleArgs)
            {
                string[] args = personArgs.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = args[0];
                decimal money = decimal.Parse(args[1]);

                try
                {
                    people.Add(new Person(name, money));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            List<Product> products = new List<Product>();

            foreach (string productArgs in productsArgs)
            {
                string[] args = productArgs.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = args[0];
                decimal price = decimal.Parse(args[1]);

                try
                {
                    products.Add(new Product(name, price));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] commandArgs = command.Split();

                string personName = commandArgs[0];
                string productName = commandArgs[1];

                var currentPerson = people.Where(x => x.Name == personName).FirstOrDefault();
                var currentProduct = products.Where(x => x.Name == productName).FirstOrDefault();

                if(currentPerson != null && currentProduct != null)
                {
                    currentPerson.BuyProduct(currentProduct);
                }
            }

            foreach(var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
