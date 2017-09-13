using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldDemo
{
    public class HelloWorld : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "Hello";
            yield return "World";
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
