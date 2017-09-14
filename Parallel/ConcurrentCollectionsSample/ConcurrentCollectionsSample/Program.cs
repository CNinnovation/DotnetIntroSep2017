using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentCollectionsSample
{
    class Program
    {
        private static BlockingCollection<int> s_coll = new BlockingCollection<int>();
        static void Main(string[] args)
        {
            WriterTask();
            ReaderTask();
            Console.ReadLine();
        }

        private static void ReaderTask()
        {
            //int result = s_coll.Take();
            Thread.Sleep(1000);
            Task.Run(() =>
            {
                foreach (int item in s_coll.GetConsumingEnumerable())
                {
                    Console.WriteLine($"reader {item}");
                }
                Console.WriteLine("complete reading");
            });
    
        }

        private static void WriterTask()
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    s_coll.Add(i);
                    Console.WriteLine($"writer {i}");
                    Thread.Sleep(100);
                }
                s_coll.CompleteAdding();
                Console.WriteLine("complete adding");
            });
        }
    }
}
