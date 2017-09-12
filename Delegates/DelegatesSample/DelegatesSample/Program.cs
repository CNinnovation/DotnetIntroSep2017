using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSample
{

    public delegate int MathOp(int x, int y);
    public delegate void VoidMathOp(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            // SimpleDelegates();
            // MultipleMethods();
            // UsingAction();
            // UsingFunc();
            //Calculator c1 = new Calculator();
            //CallAMethodViaDelegates(c1.Add);
            // SortingDemo1();
            // SortingDemoWithIComparable();
            // SortingDemoWithIComparer();
            // SortingDemoWithDelegate();
            SortingDemoWithLambdaExpression();
            // ElvisOperator();
        }

        private static void SortingDemoWithLambdaExpression()
        {
            var racers = new List<Racer>(GetRacers());
            //racers.Sort((Racer r1, Racer r2) =>
            //{
            //    return r2.Country.CompareTo(r1.Country);
            //});

            racers.Sort((Racer r1, Racer r2) =>
                r2.Country.CompareTo(r1.Country));

            foreach (var r in racers)
            {
                Console.WriteLine(r);
            }
        }

        private static void SortingDemoWithDelegate()
        {
            var racers = new List<Racer>(GetRacers());
            racers.Sort(CompareRacerByLastName);
            foreach (var r in racers)
            {
                Console.WriteLine(r);
            }
        }

        private static int CompareRacerByLastName(Racer x, Racer y) =>
            x.LastName.CompareTo(y.LastName);


        private static void SortingDemoWithIComparer()
        {
            var racers = new List<Racer>(GetRacers());
            racers.Sort(new RacerComparer(RacerCompareType.Country));
            foreach (var racer in racers)
            {
                Console.WriteLine(racer);
            }
        }

        private static void ElvisOperator()
        {
            Racer r1 = null;
            int? x1 = null;
            string name = r1?.FirstName;  // NullReferenceException
        }

        private static void SortingDemoWithIComparable()
        {
            var racers = new List<Racer>(GetRacers());
            racers.Sort();
            foreach (var racer in racers)
            {
                Console.WriteLine(racer.FirstName);
            }
        }

        private static IEnumerable<Racer> GetRacers() =>
            new List<Racer>()
            {
                new Racer { FirstName="Jochen", LastName="Rindt", Country = "Austria"},
                new Racer { FirstName="Niki", LastName="Lauda", Country = "Austria"},
                new Racer { FirstName="James", LastName="Hunt", Country = "UK"},
                new Racer { FirstName="Sebastian", LastName="Vettel", Country = "Germany"},
                new Racer { FirstName="Fernando", LastName="Alonso", Country="Spain"}
            };

        private static void SortingDemo1()
        {
            List<Racer> racers = new List<Racer>()
            {
                new Racer { FirstName="Jochen"},
                new Racer {FirstName="Niki"},
                new Racer {FirstName="James"}
            };
            racers.Sort(CompareRacersByName);

            foreach (var racer in racers)
            {
                Console.WriteLine(racer.FirstName);
            }
        }

        private static int CompareRacersByName(Racer r1, Racer r2)
        {
            return r1.FirstName.CompareTo(r2.FirstName);
        }

        public static void CallAMethodViaDelegates(Func<int, int, int> f1)
        {
            int result = f1(42, 2);
            Console.WriteLine($"result: {result}");
        }

        private static void UsingFunc()
        {
            Calculator calc = new Calculator();
            Func<int, int, int> op1 = calc.Add;
            int result = op1(7, 2);
            Console.WriteLine(result);
        }

        private static void UsingAction()
        {
            VoidCalculator calc = new VoidCalculator();
            Action<int, int> op1 = calc.Add;
            op1 += calc.Subtract;
            op1(42, 11);
        }

        private static void MultipleMethods()
        {
            //var calc = new Calculator();
            //MathOp op1 = calc.Add;
            //op1 += calc.Subtract;
            //int result = op1(7, 2);
            //Console.WriteLine(result);

            var calc = new VoidCalculator();
            VoidMathOp op1 = calc.Add;
            op1 += calc.Subtract;
            op1(27, 4);
        }

        private static void SimpleDelegates()
        {
            var calc = new Calculator();
            int result = calc.Add(3, 4);

            // var op1 = new MathOp(calc.Add);
            MathOp op1 = calc.Add; // AddressOf

            //int result1 = op1.Invoke(7, 2);
            int result1 = op1(7, 2);
            Console.WriteLine(result1);

            op1 = new MathOp(calc.Subtract);
            // int result2 = op1.Invoke(7, 2);
            int result2 = op1(7, 2);
            Console.WriteLine(result2);
        }
    }
}
