using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myIntList = new List<int>();
            myIntList.Add(4);
            myIntList.Add(7);
            myIntList.Add(9);

            int result = MyExtensions.Accumulate(myIntList, 
                (int x, int y) => x + y);
            Console.WriteLine(result);

            List<string> myStringList = new List<string>()
            {
                "one", "two", "three"
            };
            string result2 = MyExtensions.Accumulate(myStringList, (string s1, string s2) =>
            {
                return s1 + s2;
            });
            Console.WriteLine(result2);

            int result3 = MyExtensions.Accumulate(myStringList, (string s1, int x) =>
            {
                return s1.Length + x;
            });
            Console.WriteLine(result3);

            
        }
    }
}
