using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public decimal Money
        {
            get => money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        private List<Product> ProductsBought { get; set; } = new List<Product>();

        public void BuyProduct(Product product)
        {
            if (this.Money - product.Price >= 0)
            {
                ProductsBought.Add(product);
                this.Money -= product.Price;
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            if (ProductsBought.Any())
            {
                return $"{this.Name} - {string.Join(", ", ProductsBought)}";
            }
            else
            {
                return $"{this.Name} - Nothing bought";
            }
        }
    }
}
