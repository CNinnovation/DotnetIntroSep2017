using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOrStructs
{
   //  struct X  // value type
    class X // refernce type
    {
        public int a;
    }

    class Program
    {
        static  void ChangeX(ref X x1)
        {
            x1.a = 2;
            x1 = new X();
            x1.a = 3;
        }

        static void Main(string[] args)
        {
            X myX1 = new X();
            myX1.a = 1;
            ChangeX(ref myX1);
            Console.WriteLine(myX1.a);

            string s1 = "Hello, World!";  // immutable string
            s1 = s1.ToUpper();
            Console.WriteLine(s1);
        }
    }
}
