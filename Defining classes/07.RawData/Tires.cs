namespace _07.RawData
{
    public class Tires
    {
        public Tires(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }
        public double Pressure { get; set; }
        public int Age { get; set; }
    }
}
