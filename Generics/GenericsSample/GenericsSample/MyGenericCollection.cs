using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSample
{
    public class MyGenericCollection<T>
        where T : new()
    {
        private T[] _data;
        public MyGenericCollection(int size)
        {
            _data = new T[size];
        }

        public T GetItemByIndex(int index) => _data[index];
        public void SetItem(T value, int index) => _data[index] = value;

        // indexer
        public T this[int index]
        {
            get => _data[index];
            set => _data[index] = value;
        }

        public T CreateItem()
        {
            return new T();
        }
    }
}
