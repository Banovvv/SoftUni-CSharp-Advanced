namespace _02.Composite.Models
{
    public abstract class GiftBox
    {
        protected string name;
        protected int price;

        public GiftBox(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get => name; protected set { name = value; } }
        public int Price { get => price; protected set { price = value; } }

        public abstract int CalculateTotalPrice();
    }
}
