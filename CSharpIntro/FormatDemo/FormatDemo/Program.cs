using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 42;
            Console.WriteLine($"{n:X} {n:e}");

            DateTime today = DateTime.Today;
            Console.WriteLine($"{today:D} {today:d}");
        }
    }
}
