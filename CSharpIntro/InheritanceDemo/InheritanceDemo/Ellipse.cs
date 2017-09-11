using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Ellipse : Shape
    {
        public Ellipse(string name)
            : base(name)
        {

        }

        public override void Resize(int width, int height)
        {
            Height = height;
            Width = width;
        }
    }
}
