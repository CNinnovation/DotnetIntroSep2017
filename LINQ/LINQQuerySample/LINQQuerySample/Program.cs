using DataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQuerySample
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQQuery();
            // LINQWithMethods();
            // DeferredQuery();
            // GenerationSample();
            // GroupingSample();
            // GroupingSampleWithMethods();
            // CompoundFromSample();
            // CompoundFromWithMethods();
            RacersByCarSample();
        }

        private static void RacersByCarSample()
        {
           // var ferrariDrivers = GetRacersByCar("Ferrari");

           Func<string, IEnumerable<Racer>> driversByCar = car =>
               from r in Formula1.GetChampions()
               from c in r.Cars
               where c == car
               select r;

            var mcLarenDrivers = driversByCar("McLaren");
            var ferrariDrivers = driversByCar("Ferrari");
            var championsWithFerrariAndMcLaren = mcLarenDrivers.Intersect(ferrariDrivers);
            foreach (var r in championsWithFerrariAndMcLaren)
            {
                Console.WriteLine(r);
            }

        }

        private static void CompoundFromWithMethods()
        {
            //var q = Formula1.GetChampions()
            //    .Where(r => r.Cars.Contains("Ferrari"))

            var q = Formula1.GetChampions()
                .SelectMany(r => r.Cars, (r1, car) =>
                new
                {
                    Racer = r1,
                    Car = car
                })
                .Where(item => item.Car == "Ferrari")
                .Select(item => item.Racer);

            foreach (var r in q)
            {
                Console.WriteLine(r);
            }
        }

        private static void CompoundFromSample()
        {
            var q = from r in Formula1.GetChampions()
                    from c in r.Cars
                    where c == "Ferrari"
                    select r;

            foreach (var r in q)
            {
                Console.WriteLine($"{r:A}");
            }
        }

        private static IEnumerable<Racer> GetRacersByCar(string car)
        {
            var q = from r in Formula1.GetChampions()
                    from c in r.Cars
                    where c == car
                    select r;
            return q;
        }

        private static void GroupingSampleWithMethods()
        {
            var q = Formula1.GetChampions()
               .GroupBy(r => r.Country)
               .OrderByDescending(g => g.Count())
               .ThenBy(g => g.Key).Take(6);

            foreach (var group in q)
            {
                Console.WriteLine($"{group.Key} {group.Count()}");
            }
        }

        private static void GroupingSample()
        {
            var q = (from r in Formula1.GetChampions()
                     group r by r.Country into g
                     let count = g.Count()
                     orderby count descending, g.Key
                     select new  // anonymous type
                     {
                         Country = g.Key,
                         Count = count,
                         Racers = from r1 in g
                                  orderby r1.Wins descending, r1.LastName
                                  select $"{r1.FirstName} {r1.LastName}" 
                     }
                     ).Take(6);

            foreach (var group in q)
            {
                Console.WriteLine($"{group.Country} {group.Count}");
                foreach (var r in group.Racers)
                {
                    Console.WriteLine($"\t{r}");
                }
            }

        }

        private static void GenerationSample()
        {
            var data = Enumerable.Range(0, 100000).Select(x => new SomeData() { Number = x, Text = $"text: {x}" });
            foreach (var d in data)
            {
                Console.WriteLine($"{d.Number} {d.Text}");
            }
        }

        private static void DeferredQuery()
        {
            List<string> names = new List<string>() { "Niki", "James", "John", "Gerhard" };
            var q = (from n in names
                     where n.StartsWith("J")
                     select n).ToList();

            var q1 = names.Where(n => n.StartsWith("J")).ToList();

            foreach (var n in q)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            names.Add("Juan");
            names.Add("Niki");
            names.Add("Jochen");

            Console.WriteLine("2nd iteration");
            foreach (var n in q)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine($"count: {q.Count()}");



        }

        private static void LINQWithMethods()
        {
            var q = Formula1.GetChampions()
                .Where(r => r.Country == "Austria")
                .OrderByDescending(r => r.Wins)
                .ThenBy(r => r.LastName)
                .Select(r => r);

            foreach (var r in q)
            {
                Console.WriteLine($"{r:A}");
            }
        }

        private static void LINQQuery()
        {
            var q = from r in Formula1.GetChampions()
                    where r.Country == "Austria"
                    orderby r.Wins descending, r.LastName
                    select r;

            foreach (var r in q)
            {
                Console.WriteLine($"{r:A}");
            }
        }
    }
}
