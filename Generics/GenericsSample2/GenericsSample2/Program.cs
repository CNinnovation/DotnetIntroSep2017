using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { FirstName = "Katharina" });
            people.Add(new Person { FirstName = "Stephanie" });

            List<Rectangle> rectangles = new List<Rectangle>();
            rectangles.Add(new Rectangle { Width = 20, Height = 40 });

            DisplaySomething(people[0]);
            DisplaySomething(rectangles[0]);
        }

        public static void DisplaySomething<T>(T item)
            where T : IDisplayable  // constraint
        {
            item.Show();
        }


    }
}
