using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // CallGreetings();
            ThrowErrorsAsync();
            Console.WriteLine("main finished");
            Console.ReadLine();
        }

        private static async void ThrowErrorsAsync()
        {
            Task resultTask = null;
            try
            {
                Task t1 = ThrowErrorAfterAsync("first", 3000);
                Task t2 =  ThrowErrorAfterAsync("second", 2000);
                resultTask = Task.WhenAll(t2, t1);
                await resultTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"exception: {ex.Message}");
                foreach (var exception in resultTask.Exception.InnerExceptions)
                {
                    Console.WriteLine($"{exception.Message}");
                }
            }
        }


        private static async void CallGreetings()
        {
            Task<string> t1 = GreetingAsync("Katharina", 4000);
            Task<string> t2 = GreetingAsync("Stephanie", 2000);
            await Task.WhenAll(t1, t2);

            Console.WriteLine(t1.Result);
            Console.WriteLine(t2.Result);
            
        }

        static Task<string> GreetingAsync(string s, int ms)
        {
            return Task<string>.Run<string>(() =>
            {
                return Greeting(s, ms);
            });
        }

        static string Greeting(string s, int ms)
        {
            Thread.Sleep(ms);
            return $"Hello, {s}";
        }

        static Task ThrowErrorAfterAsync(string message, int ms)
        {
            return Task.Run(() =>
            {
                ThrowErrorAfter(message, ms);
            });
        }

        static void ThrowErrorAfter(string message, int ms)
        {
            Thread.Sleep(ms);
            throw new Exception(message);
        }
    }
}
