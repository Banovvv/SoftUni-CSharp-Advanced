using _08.CollectionHierarchy.Models;
using System;

namespace _08.CollectionHierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();

            #region Add
            string[] elements = Console.ReadLine().Split();

            foreach (string element in elements)
            {
                Console.Write($"{addCollection.Add(element)} ");
            }

            Console.WriteLine();

            foreach (string element in elements)
            {
                Console.Write($"{addRemoveCollection.Add(element)} ");
            }

            Console.WriteLine();

            foreach (string element in elements)
            {
                Console.Write($"{myList.Add(element)} ");
            }

            Console.WriteLine();
            #endregion

            #region Remove
            int elementsToRemove = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < elementsToRemove; i++)
            {
                Console.Write($"{addRemoveCollection.Remove()} ");
            }

            Console.WriteLine();

            for (int i = 0; i < elementsToRemove; i++)
            {
                Console.Write($"{myList.Remove()} ");
            }

            Console.WriteLine();
            #endregion
        }
    }
}
