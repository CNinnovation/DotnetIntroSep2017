using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r11 = new Rectangle(nameof(r11));
            //var pos1 = new Position();
            //pos1.X = 42;
            //pos1.Y = 11;

            var pos1 = new Position
            {
                X = 42,
                Y = 11
            };
            r11.Move(pos1);

            r11.Move(new Position
            {
                X = 420,
                Y = 20
            });
            Console.WriteLine();

            Shape[] shapes = new Shape[]
            {
                r11, new Ellipse(nameof(Ellipse))
            };

            foreach (var shape in shapes)
            {
                shape.Move(new Position { X = 1, Y = 1 });
                DisplaySomething(shape);
            }

            Shape newShape = new Ellipse(nameof(newShape));

        }

        public static void DisplaySomething(IDisplayable d)
        {
            d.Display();
        }
    }
}
