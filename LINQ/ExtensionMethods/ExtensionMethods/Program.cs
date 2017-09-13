using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            s.Foo(42);
            StringExtensions.Foo(s, 42);
            int i = 42;
            i.Foo();
        }
    }
}
