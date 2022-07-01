namespace _01.PrototypеPattern.Models
{
    public class SandwichMenuItem
    {
        public SandwichMenuItem(string name, SandwichPrototype sandwich)
        {
            Name = name;
            Sandwich = sandwich;
        }

        public string Name { get; private set; }
        public SandwichPrototype Sandwich { get; private set; }

    }
}
