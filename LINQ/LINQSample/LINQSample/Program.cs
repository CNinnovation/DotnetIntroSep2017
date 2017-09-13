using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace LINQSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "James", "Niki", "John", "Juan", "Fernando" };
            //var jNames = names.FindAll(new Predicate<string>(n => n.StartsWith("J")));

            //foreach (var j in jNames)
            //{
            //    Console.WriteLine(j);
            //}

            var jNames = names.Filter(n => n.StartsWith("J"));
            foreach (var j in jNames)
            {
                Console.WriteLine(j);
            }
        }
    }
}
