using System.Collections.Generic;

namespace _01.PrototypеPattern.Models
{
    public partial class SandwichMenu
    {
        public SandwichMenu()
        {
            Sandwiches = new List<SandwichMenuItem>();
        }

        public List<SandwichMenuItem> Sandwiches { get; private set; }

        public void Add(string name, SandwichPrototype sandwich)
        {
            Sandwiches.Add(new SandwichMenuItem(name, sandwich));
        }
    }
}
