using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static void Foo(this string s, int x)
        {
            Console.WriteLine($"Foo, {s} {x}");
        }
    }
}
