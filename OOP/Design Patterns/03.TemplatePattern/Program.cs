using _03.TemplatePattern.Models;
using System.Collections.Generic;
using System.Threading;

namespace _03.TemplatePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Bread> breads = new List<Bread>
            {
                new Sourdough(),
                new TwelveGrain(),
                new WholeWheat(),
                new Ciabatta(),
                new Baguette()
            };

            foreach (var bread in breads)
            {
                bread.Make();
                Thread.Sleep(1000);
            }
        }
    }
}
