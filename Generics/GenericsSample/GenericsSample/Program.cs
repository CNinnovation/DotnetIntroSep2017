using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListSample();
            //ListSample();
            UseMyCollection();
            UseMyGenericCollection();
        }

        private static void UseMyGenericCollection()
        {
            MyGenericCollection<int> coll1 = new MyGenericCollection<int>(4);
            coll1.SetItem(42, 0);
            coll1[1] = 11;


            //MyGenericCollection<string> coll2 = new MyGenericCollection<string>(2);
            //coll2[1] = "abc";

            MyGenericCollection<Rectangle> coll3 = new MyGenericCollection<Rectangle>(3);
            Rectangle r2 = coll3.CreateItem();
            r2.Height = 20;
            r2.Width = 20;
        }

        private static void UseMyCollection()
        {
            MyCollection coll1 = new MyCollection(4);
            coll1[0] = "one";
            coll1[1] = 4;
            coll1[2] = "abc";
            coll1[3] = 42;

            int a1 = (int)coll1[1];
            Console.WriteLine(a1);
        }

        private static void ListSample()
        {
            List<int> intList = new List<int>();
            intList.Add(42);  // no boxing!
            intList.Add(4);

            foreach (int x in intList)
            {
                Console.WriteLine(x);
            }

            List<string> stringList = new List<string>();
            stringList.Add("one");
        }

        private static void ArrayListSample()
        {
            ArrayList list1 = new ArrayList();
            list1.Add(4); // boxing
            list1.Add(7);
            // list1.Add("9");
            list1.Add(11);

            list1[2] = 44;

            object o1 = list1[2];

            //int x = 3;
            //object o = x;

            foreach (int x in list1)  // unboxing
            {
                Console.WriteLine(x);
            }

            IEnumerator enumerator = list1.GetEnumerator();

            while (enumerator.MoveNext())
            {
                int x = (int)enumerator.Current;
                Console.WriteLine(x);
            }


        }
    }
}
