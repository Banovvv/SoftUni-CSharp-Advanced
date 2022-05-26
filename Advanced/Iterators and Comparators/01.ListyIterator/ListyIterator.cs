using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        private int index = 0;

        public ListyIterator(List<T> elements)
        {
            Elements = elements;
        }

        public List<T> Elements { get; set; } = new List<T>();

        public bool Move()
        {
            if (index + 1 < Elements.Count)
            {
                index++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasNext()
        {
            return index + 1 < Elements.Count;
        }
        public void Print()
        {
            if (!Elements.Any())
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(Elements[index]);
            }
        }
    }
}
