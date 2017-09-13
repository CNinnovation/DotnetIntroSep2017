using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] data = { "one", "two", "three" };

            //foreach (string s in data)
            //{
            //    Console.WriteLine(s);
            //}

            //IEnumerator enumerator = data.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}
            var hw = new HelloWorld();
            foreach (string s in hw)
            {
                Console.WriteLine(s);
            }
        }
    }
}
