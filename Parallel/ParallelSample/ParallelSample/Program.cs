using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"running in the main thread {Thread.CurrentThread.ManagedThreadId}");
            // ThreadDemo();
            // ThreadPoolDemo();
            // TaskDemo();
            // ParallelDemo();
            // ParallelData();
            // ParallelLinq();
            ParallelDemoWithCancellation();
            Console.ReadLine();
        }

        private static void ParallelDemoWithCancellation()
        {
            var data = Enumerable.Range(0, 10000).Select(x => new SomeData { Number = x, Text = $"text {x}" }).ToList();

            CancellationTokenSource cts = new CancellationTokenSource();
            Task.Run(() =>
            {
                Thread.Sleep(1500);
                Console.WriteLine("cancel now");
                cts.Cancel();
            });

            try
            {

                Parallel.ForEach(data, new ParallelOptions() { CancellationToken = cts.Token }, sd =>
                {
                    Console.WriteLine($"started loop {sd.Number}, in task {Task.CurrentId}");
                    Thread.Sleep(500);
                    Console.WriteLine($"finished loop {sd.Number}, in task {Task.CurrentId}");
                });
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("end of ForEach");
        }

        private static void ParallelLinq()
        {
            Random r = new Random();
            var data = Enumerable.Range(0, 10000).Select(x => new SomeData { Number = r.Next(0, 1000), Text = $"text {x}" }).ToList();

            data.AsParallel().Where(sd => sd.Number > 500)
                .Select(sd => sd)
                .ForAll(sd =>
                {
                    Console.WriteLine($"{sd.Number} {sd.Text}, task: {Task.CurrentId}, thread: {Thread.CurrentThread.ManagedThreadId}");
                });
            //foreach (var item in q)
            //{
            //    Console.WriteLine($"{item.Number} {item.Text}");
            //}
        }

        private static void ParallelData()
        {
            var data = Enumerable.Range(0, 10000).Select(x => new SomeData { Number = x, Text = $"text {x}" }).ToList();
            Parallel.ForEach(data, sd =>
            {
                Console.WriteLine($"started loop {sd.Number}, in task {Task.CurrentId}");
                Thread.Sleep(500);
                Console.WriteLine($"finished loop {sd.Number}, in task {Task.CurrentId}");
            });

            //Parallel.For(0, 1000, x =>
            //{

            //});
        }

        private static void ParallelDemo()
        {
            Parallel.Invoke(
                MyParallel, MyParallel, MyParallel);
        }

        private static void MyParallel()
        {
            Console.WriteLine($"started {Task.CurrentId}");
            Thread.Sleep(1000);
            Console.WriteLine($"finished {Task.CurrentId}");
        }

        private static void TaskDemo()
        {
            Task t1 = new Task(MyTask);
            t1.Start();

            Task t2 = new Task(MyTask, TaskCreationOptions.LongRunning);
            t2.Start();

            Task t3 = new Task(MyTask);
            t3.RunSynchronously();

        }

        private static void MyTask()
        {
            Console.WriteLine($"task: {Task.CurrentId}, thread: {Thread.CurrentThread.ManagedThreadId}, background: {Thread.CurrentThread.IsBackground} pooled: {Thread.CurrentThread.IsThreadPoolThread}");
        }

        private static void ThreadPoolDemo()
        {
            ThreadPool.GetMaxThreads(out int worker, out int io);

            Console.WriteLine($"worker: {worker}, io: {io}");
            for (int i = 0; i < 100; i++)
            {
                ThreadPool.QueueUserWorkItem(MyPooledThread);
            }
        }

        private static void MyPooledThread(object o)
        {
            Console.WriteLine($"start running in a thread {Thread.CurrentThread.ManagedThreadId}, background: {Thread.CurrentThread.IsBackground}");
            Thread.Sleep(1000);
            Console.WriteLine($"finished {Thread.CurrentThread.ManagedThreadId}");
        }

        private static void ThreadDemo()
        {
            Thread t1 = new Thread(MyThread) { IsBackground = true };
            t1.Start();
        }

        private static void MyThread()
        {
            Thread.Sleep(2000);
            Console.WriteLine($"running in a thread {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
