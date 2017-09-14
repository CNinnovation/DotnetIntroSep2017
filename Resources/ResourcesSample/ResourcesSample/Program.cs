using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourcesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = File.Create("sample.txt")) // using not necessary, writer closes stream!
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine("Hello, World!");
            }  // close writer and stream
        }
    }
}
