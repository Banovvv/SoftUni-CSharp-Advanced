using _01.PrototypеPattern.Models;
using System.Linq;

namespace _01.PrototypеPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            SandwichMenu sandwichMenu = new SandwichMenu();

            sandwichMenu.Add("BLT", new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato"));
            sandwichMenu.Add("PB&J", new Sandwich("White", "", "", "Peanut Butter, Jelly"));
            sandwichMenu.Add("Turkey", new Sandwich("Rye", "Turkey", "Swiss Cheese", "Lettuce, Onion, Tomato"));
            sandwichMenu.Add("LoadedBLT", new Sandwich("Wheat", "Turkey, Bacon", "American Cheese", "Lettuce, Tomato, Onion, Olives"));
            sandwichMenu.Add("ThreeMeatCombo", new Sandwich("Rye", "Turkey, Ham, Salami", "Provolone Cheese", "Lettuce, Onion"));
            sandwichMenu.Add("Vegeterian", new Sandwich("Wheat", "", "", "Lettuce, Onion, Olives, Spinach, Tomato"));

            Sandwich cloneOne = sandwichMenu.Sandwiches.Where(x => x.Name == "BLT").First().Sandwich.Clone() as Sandwich;
            Sandwich cloneTwo = sandwichMenu.Sandwiches.Where(x => x.Name == "ThreeMeatCombo").First().Sandwich.Clone() as Sandwich;
            Sandwich cloneThree = sandwichMenu.Sandwiches.Where(x => x.Name == "Turkey").First().Sandwich.Clone() as Sandwich;
        }
    }
}
