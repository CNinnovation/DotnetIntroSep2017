using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public abstract class Shape : IDisplayable
    {

        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Display {Name} --- Width: {Width}, height: {Height}");
        }

        public virtual void Move(Position position)
        {
            Position = position;
            Console.WriteLine($"Shape.Move {position}");
        }

        public abstract void Resize(int width, int height);
    }
}
