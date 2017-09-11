using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Rectangle : Shape
    {
        public Rectangle(string name)
            : base(name)
        {

        }
        public override void Move(Position position)
        {
            base.Move(position);
            Console.WriteLine($"Rectangle.Move - move to {position}");
        }

        public override void Resize(int width, int height)
        {
            Height = height;
            Width = width;
        }
    }
}
