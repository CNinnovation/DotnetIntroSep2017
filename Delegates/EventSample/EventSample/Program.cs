using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new CarFactory();
            var fernando = new Consumer("Fernando");
            factory.CarCreated += fernando.CarArrived;

            factory.CreateACar("Ferrari");
            var seb = new Consumer("Seb");
            factory.CarCreated += seb.CarArrived;
            factory.CreateACar("McLaren");

            factory.CarCreated -= fernando.CarArrived;

            factory.CreateACar("Mercedes");
        }


    }
}
