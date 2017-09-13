using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // ListDemo();
            // QueueDemo();
            // StackDemo();
            LinkedListDemo();
        }

        private static void LinkedListDemo()
        {
            var myList = new LinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                LinkedListNode<int> node = myList.AddLast(i);
            }
        }

        private static void StackDemo()
        {
            Stack<int> myStack = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                myStack.Push(i);
            }

            for (int i = 0; i < 10; i++)
            {
                int n = myStack.Pop();
                Console.WriteLine($"retrieved {n}");
            }
        }

        private static void QueueDemo()
        {

            Queue<int> myQueue = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                myQueue.Enqueue(i);
            }

            for (int i = 0; i < 10; i++)
            {
                int n = myQueue.Dequeue();
                Console.WriteLine($"retrieved {n}");
            }
        }

        private static void ListDemo()
        {
            List<int> intList = new List<int>(2200);
            for (int i = 0; i < 100; i++)
            {
                intList.Add(i);
                Console.WriteLine($"added {i}, capacity: {intList.Capacity}");
            }

            intList.Insert(22, 42);

        }
    }
}
