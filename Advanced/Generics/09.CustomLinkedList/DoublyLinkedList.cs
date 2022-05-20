using System;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            if (Count == 0)
            {
                head = tail = new ListNode<T>(element);
            }
            else
            {
                ListNode<T> newHead = new ListNode<T>(element);
                newHead.NextNode = head;
                head.PreviousNode = newHead;
                head = newHead;
            }

            Count++;
        }

        public void AddLast(T element)
        {
            if (Count == 0)
            {
                tail = head = new ListNode<T>(element);
            }
            else
            {
                ListNode<T> newTail = new ListNode<T>(element);
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }

            Count++;
        }

        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new Exception("The list is empty!");
            }
            else if (Count == 1)
            {
                T value = head.Value;
                head = tail = null;

                Count--;

                return value;
            }
            else
            {
                T value = head.Value;

                ListNode<T> newHead = head.NextNode;
                newHead.PreviousNode = null;

                head = newHead;

                Count--;

                return value;
            }
        }

        public void ForEach(Action<T> action)
        {
            ListNode<T> currentNode = head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public T[] ToArray()
        {
            if (Count == 0)
            {
                throw new Exception("The list is empty!");
            }

            T[] array = new T[Count];

            int counter = 0;
            ListNode<T> currentNode = head;

            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                counter++;

                currentNode = currentNode.NextNode;
            }

            return array;
        }

        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new Exception("The list is empty!");
            }
            else if (Count == 1)
            {
                T value = head.Value;
                head = tail = null;

                Count--;

                return value;
            }
            else
            {
                T value = tail.Value;

                ListNode<T> newTail = tail.PreviousNode;
                newTail.NextNode = null;

                tail = newTail;

                Count--;

                return value;
            }
        }

        private class ListNode<T>
        {
            public ListNode(T value)
            {
                Value = value;
            }

            public T Value { get; set; }
            public ListNode<T> NextNode { get; set; }
            public ListNode<T> PreviousNode { get; set; }
        }
    }
}
