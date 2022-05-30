using System;

namespace _02.RecursiveFactorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialSum(n));
        }

        static long FactorialSum(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * FactorialSum(n - 1);
        }
    }
}
