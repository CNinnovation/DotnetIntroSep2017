using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSample
{
    public static class CollectionExtensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> pred)
        {
            foreach (T item in source)
            {
                if (pred(item))
                {
                    yield return item;
                }
            }
        }
    }
}
