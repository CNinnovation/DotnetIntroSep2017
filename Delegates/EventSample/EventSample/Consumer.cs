using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    public class Consumer
    {
        private string _name;
        public Consumer(string name) => _name = name;

        public void CarArrived(string car)
        {
            Console.WriteLine($"{_name}: car {car} is here");
        }
    }
}
