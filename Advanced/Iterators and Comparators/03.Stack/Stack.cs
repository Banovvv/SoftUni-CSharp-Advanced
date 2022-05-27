using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        public Stack(params T[] elements)
        {
            Elements = new List<T>(elements);
        }

        public List<T> Elements { get; set; }

        public void Push(T element)
        {
            Elements.Add(element);
        }

        public T Pop()
        {
            if (Elements.Count == 0)
            {
                Console.WriteLine("No elements");
                return default(T);
            }

            T element = Elements.Last();
            Elements.Remove(element);

            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Elements.Count - 1; i >= 0; i--)
            {
                yield return Elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
