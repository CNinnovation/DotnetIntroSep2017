using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        //public override string ToString()
        //{
        //    return $"x: {X}, y: {Y}";
        //}

        public override string ToString() => $"x: {X}, y: {Y}";
    }
}
