using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypesSample
{
    public struct MyStruct
    {
        public int A;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Foo();

        }

        public static void Foo()
        {
            int i1 = 42;  // struct - value type - uses stack
            string s1 = "hello";
            object o1 = i1;  // boxing
            Bar(i1);  // boxing

            int? i2 = null;

            MyStruct myStruct1 = new MyStruct();
            myStruct1.A = 42;
            MyStruct? myStruct2 = null;  // still on the stack!!

            int x1 = 1;
            int? x2 = x1;
            int? x3 = null;
            int x4;
            if (x3.HasValue)
            {
                x4 = x3.Value;
            }
            else
            {
                x4 = -1; // default if null
            }
            // int x5 = (int)x3;  // exception because null!

            int x6 = x3.HasValue ? x3.Value : -1;
            int x7 = x3 ?? -1;  // coalescing operator


        }

        public static void Bar(object o)
        {

        }
    }
}
