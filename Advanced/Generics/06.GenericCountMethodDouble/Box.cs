using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    public class Box<T> where T : IComparable
    {
        public Box(List<T> values)
        {
            Values = values;
        }

        public static List<T> Values { get; set; }

        public int CountEqualElements(T element)
        {
            int count = 0;

            foreach (T value in Values)
            {
                if (value.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
