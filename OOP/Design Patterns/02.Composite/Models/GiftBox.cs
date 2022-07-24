namespace _02.Composite.Models
{
    public abstract class GiftBox
    {
        protected string name;
        protected int price;

        public GiftBox(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract int CalculateTotalPrice();
    }
}
