using DataLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTreeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<Racer, bool>> f1 = r => r.Country == "Brazil" && r.Wins > 6;
        }
    }
}
