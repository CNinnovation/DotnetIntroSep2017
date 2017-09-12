using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSample
{
    public class MyCollection
    {
        private object[] _data;
        public MyCollection(int size)
        {
            _data = new object[size];
        }

        //public object GetItemByIndex(int index) => _data[index];
        //public void SetItem(object value, int index) => _data[index] = value;

        // indexer
        public object this[int index]
        {
            get => _data[index];
            set => _data[index] = value;
        }

    }
}
