using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    internal class Program
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());

            int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int intelligenceValue = int.Parse(Console.ReadLine());
            int moneyEarned = intelligenceValue;

            Stack<int> bullets = new Stack<int>(bulletsInput);
            Queue<int> locks = new Queue<int>(locksInput);

            int currentBarrel = barrelSize;

            while (true)
            {
                if (currentBarrel == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                    currentBarrel = barrelSize;
                }

                int currentBullet;
                int currentLock;

                if (locks.Any())
                {
                    currentLock = locks.Peek();
                }
                else
                {
                    break;
                }
                if (bullets.Any())
                {
                    currentBullet = bullets.Pop();
                    moneyEarned -= bulletPrice;

                    currentBarrel--;
                }
                else
                {
                    break;
                }
                

                if(currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
            }

            if (bullets.Any() || locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
