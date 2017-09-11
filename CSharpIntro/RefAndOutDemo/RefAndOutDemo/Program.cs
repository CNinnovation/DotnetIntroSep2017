using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutDemo
{
    class Program
    {
        static void Add(int x, int y, out int result)
        {
            result = x + y;
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static (int Result, int Remainder) Divide(int x, int y)
        {
            int result = x / y;
            int remainder = x % y;
            return (result, remainder);
        }

        static void Main(string[] args)
        {
            Add(3, 4, out int result);
            Console.WriteLine(result);

            int result2 = Add(40, 2);
            Console.WriteLine(result2);

            Console.WriteLine("give me a number");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result3))
            {
                Console.WriteLine($"das war eine nummer: {result3}");
            }
            else
            {
                Console.WriteLine("das war keine nummer");
            }

            (int result4, int remainder) = Divide(7, 2);  // tuples - C# 7
            Console.WriteLine($"result: {result4}, remainder: {remainder}");
        }
    }
}
