using Intro1.Sample1;
using Intro1.Sample2;
using System;
using System.Collections;
using S2 = Intro1.Sample2;  // alias

namespace Intro1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1;
            x1 = 1;
            int x2 = 2;
            System.Console.WriteLine(x2);
            Console.WriteLine(x1);

            var x3 = 3;
            string s1 = "Hello";
            var s2 = "World";

            var p1 = new Person();
            Person p2 = new Person();


            //ProgramFlowSample1(3);
            //ProgramFlowSample2();
            //LoopSample1();
            //NamespaceSample();
            PropertySample();
            ConstSample();
            ConstructorSample();
        }

        private static void ConstructorSample()
        {
            var p1 = new Person();
            Console.WriteLine("person count:  {0}", Person.PersonCount);
            Console.WriteLine($"person count: {Person.PersonCount}"); // C# 6 - interpolated string
            var p2 = new Person("Katharina");
            Console.WriteLine($"person count: {Person.PersonCount}");
        }

        private static void ConstSample()
        {
            int maxPersons = Person.MaxPersons;
        }

        private static void PropertySample()
        {
            Person p1 = new Person();
            p1.FirstName = "Stephanie";  // set accessor
            Console.WriteLine(p1.FirstName);  // get accessor
        }

        private static void NamespaceSample()
        {
            S2.Demo1 d1 = new S2.Demo1();
        }

        private static void LoopSample1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int[] arr1 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr1[i] = i;
            }

            int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr3 = { 1, 2, 3, 4, 5 };

            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            }

            IEnumerator enumerator = arr3.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        private static void ProgramFlowSample2()
        {
            WeekDay day = WeekDay.Monday;

            switch (day)
            {
                case WeekDay.Monday:
                    Console.WriteLine("it's Monday");
                    break;
                case WeekDay.Tuesdey:
                    Console.WriteLine("it's Tuesday");
                    break;
                case WeekDay.Wednesday:
                    break;
                default:
                    break;
            }

        }

        private static void ProgramFlowSample1(int a)
        {
            if (a == 3)
            {
                Console.WriteLine("a is 3");
            }
            else
            {
                Console.WriteLine("a is not 3");
            }
        }
    }
}
