using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSample
{
    class VoidCalculator
    {
        public void Add(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
        public void Subtract(int x, int y) => Console.WriteLine($"{x} - {y} = {x - y}");
    }
}
