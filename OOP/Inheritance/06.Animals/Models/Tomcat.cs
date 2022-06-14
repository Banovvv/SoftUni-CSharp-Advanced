namespace Animals
{
    public class Tomcat : Cat
    {
        private static string TomcatGender = "Male";
        public Tomcat(string name, int age) : base(name, age, TomcatGender)
        {
        }

        public override string ProduceSound() => "MEOW";
    }
}
