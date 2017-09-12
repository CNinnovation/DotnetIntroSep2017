using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSample2
{
    public class Person : IDisplayable
    {
        public string FirstName { get; set; }

        public void Show()
        {
            Console.WriteLine($"Person: {FirstName}");
        }
    }
}
