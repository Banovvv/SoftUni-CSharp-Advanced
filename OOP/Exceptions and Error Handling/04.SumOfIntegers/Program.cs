using System;

namespace _04.SumOfIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] elementsToSum = Console.ReadLine().Split();
            int sum = 0;

            foreach (string element in elementsToSum)
            {
                try
                {
                    sum += int.Parse(element);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{element}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{element}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
