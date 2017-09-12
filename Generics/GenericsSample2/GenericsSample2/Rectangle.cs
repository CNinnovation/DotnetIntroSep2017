using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSample2
{
    public class Rectangle : IDisplayable
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Show() => Console.WriteLine($"Rectangle: {Width} x {Height}");
    }
}
