namespace Animals
{
    public class Kitten : Cat
    {
        private static string KittenGender = "Female";
        public Kitten(string name, int age) : base(name, age, KittenGender)
        {
        }

        public override string ProduceSound() => "Meow";
    }
}
