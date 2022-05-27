using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
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

        public void PrintAll()
        {
            foreach (T element in Elements)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                yield return Elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
