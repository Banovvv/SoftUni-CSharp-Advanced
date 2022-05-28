using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BakeryShop
{
    public class Program
    {
        static void Main()
        {
            Queue<double> water = new Queue<double>(Console.ReadLine().Split().Select(double.Parse));
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split().Select(double.Parse));

            Dictionary<string, int> products = new Dictionary<string, int>();

            while(water.Count > 0 && flour.Count > 0)
            {
                double currentWater = water.Dequeue();
                double currentFlour = flour.Pop();

                double waterPercentage = (currentWater * 100) / (currentWater + currentFlour);
                double flourPercentage = (currentFlour * 100) / (currentWater + currentFlour);

                if(waterPercentage == 40 && flourPercentage == 60)
                {
                    //Muffin
                    if (products.ContainsKey("Muffin"))
                    {
                        products["Muffin"] += 1;
                    }
                    else
                    {
                        products.Add("Muffin", 1);
                    }
                }
                else if (waterPercentage == 30 && flourPercentage == 70)
                {
                    //Baguette
                    if (products.ContainsKey("Baguette"))
                    {
                        products["Baguette"] += 1;
                    }
                    else
                    {
                        products.Add("Baguette", 1);
                    }
                }
                else if (waterPercentage == 20 && flourPercentage == 80)
                {
                    //Bagel
                    if (products.ContainsKey("Bagel"))
                    {
                        products["Bagel"] += 1;
                    }
                    else
                    {
                        products.Add("Bagel", 1);
                    }
                }
                else
                {
                    //Croissant
                    if (products.ContainsKey("Croissant"))
                    {
                        products["Croissant"] += 1;
                    }
                    else
                    {
                        products.Add("Croissant", 1);
                    }

                    double flourLeft = currentFlour - currentWater;

                    if(flourLeft > 0)
                    {
                        flour.Push(flourLeft);
                    }
                }
            }

            foreach(var product in products.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }

            Console.WriteLine($"Water left: {(water.Any() ? string.Join(", ", water) : "None")}");
            Console.WriteLine($"Flour left: {(flour.Any() ? string.Join(", ", flour) : "None")}");
        }
    }
}
