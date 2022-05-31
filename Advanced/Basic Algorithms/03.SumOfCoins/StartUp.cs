using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumOfCoins
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var coins = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int targetSum = int.Parse(Console.ReadLine());

            var coinsUsed = ChooseCoins(coins, targetSum);

            Console.WriteLine($"Number of coins to take: {coinsUsed.Sum(x=>x.Value)}");
            foreach (var coin in coinsUsed)
            {
                Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            var coinsUsed = new Dictionary<int, int>();

            coins = coins.OrderByDescending(x => x).ToList();

            for (int i = 0; i < coins.Count; i++)
            {
                int currentCoin = coins.ElementAt(i);

                if (targetSum - currentCoin >= 0)
                {
                    coinsUsed.Add(currentCoin, 0);
                    while (targetSum - currentCoin >= 0)
                    {
                        targetSum -= currentCoin;
                        coinsUsed[currentCoin]++;
                    }
                }
            }

            if(targetSum != 0)
            {
                throw new InvalidOperationException();
            }

            return coinsUsed;
        }
    }
}
