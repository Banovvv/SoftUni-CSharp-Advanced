using System;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (Count == 0)
            {
                head = tail = new ListNode(element);
            }
            else
            {
                ListNode newHead = new ListNode(element);
                newHead.NextNode = head;
                head.PreviousNode = newHead;
                head = newHead;
            }

            Count++;
        }

        public void AddLast(int element)
        {
            if (Count == 0)
            {
                tail = head = new ListNode(element);
            }
            else
            {
                ListNode newTail = new ListNode(element);
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }

            Count++;
        }

        public int RemoveFirst()
        {
            if (Count == 0)
            {
                throw new Exception("The list is empty!");
            }
            else if (Count == 1)
            {
                int value = head.Value;
                head = tail = null;

                Count--;

                return value;
            }
            else
            {
                int value = head.Value;

                ListNode newHead = head.NextNode;
                newHead.PreviousNode = null;

                head = newHead;

                Count--;

                return value;
            }
        }

        public void ForEach(Action<int> action)
        {
            ListNode currentNode = head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public int[] ToArray()
        {
            if (Count == 0)
            {
                throw new Exception("The list is empty!");
            }

            int[] array = new int[Count];

            int counter = 0;
            ListNode currentNode = head;

            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                counter++;

                currentNode = currentNode.NextNode;
            }

            return array;
        }

        public int RemoveLast()
        {
            if (Count == 0)
            {
                throw new Exception("The list is empty!");
            }
            else if (Count == 1)
            {
                int value = head.Value;
                head = tail = null;

                Count--;

                return value;
            }
            else
            {
                int value = tail.Value;

                ListNode newTail = tail.PreviousNode;
                newTail.NextNode = null;

                tail = newTail;

                Count--;

                return value;
            }
        }

        private class ListNode
        {
            public ListNode(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }
        }
    }
}
