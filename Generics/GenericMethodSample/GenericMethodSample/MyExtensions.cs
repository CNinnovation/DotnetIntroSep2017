using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodSample
{
    public class MyExtensions
    {
        public static T2 Accumulate<T1, T2>(IEnumerable<T1> source, Func<T1, T2, T2> action)
        {
            // T2 sum = default(T2);  // C# 7.0
            T2 sum = default; // C# 7.1
            foreach (T1 item in source)
            {
                sum = action(item, sum);
            }
            return sum;
        }
    }
}
