using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample
{
    public delegate void CarInfo(string car);

    public class CarFactory
    {
        //private CarInfo _carCreated;
        //public event CarInfo CarCreated
        //{
        //    add
        //    {
        //        _carCreated += value;
        //    }
        //    remove
        //    {
        //        _carCreated -= value;
        //    }
        //}

        public event CarInfo CarCreated;
        public void CreateACar(string car)
        {
            Console.WriteLine($"CarFactory creates a car {car}");
            // _carCreated(car);  maybe NullReferenceException

            //CarInfo handler = _carCreated;
            //if (handler != null)
            //{
            //    handler(car);
            //}

            //if (_carCreated != null)  // dangerous!! - race condition
            //{
            //    _carCreated(car);
            //}

            CarCreated?.Invoke(car);  // thread-safe
        }
    }
}
