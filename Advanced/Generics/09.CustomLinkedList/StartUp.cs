using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList customList = new DoublyLinkedList();

            customList.AddFirst(3);
            customList.AddLast(4);
            Console.WriteLine(string.Join("-", customList.ToArray()));
            // 3-4

            customList.AddFirst(2);
            customList.AddFirst(1);
            customList.AddFirst(0);
            Console.WriteLine(string.Join("-", customList.ToArray()));
            // 0-1-2-3-4

            customList.RemoveFirst();
            customList.RemoveLast();
            Console.WriteLine(string.Join("-", customList.ToArray()));
            // 1-2-3

            customList.ForEach(x => Console.WriteLine(x));
            //1
            //2
            //3
        }
    }
}
