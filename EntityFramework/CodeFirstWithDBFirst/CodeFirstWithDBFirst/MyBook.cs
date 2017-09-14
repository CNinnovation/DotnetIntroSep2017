using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWithDBFirst
{
    partial class MyBook
    {
        public override string ToString() =>
            $"{Title}, publisher: {Publisher}";
    }
}
