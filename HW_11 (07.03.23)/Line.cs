using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11__07._03._23_
{
    internal class Line: Shape
    {
        public Point Start { get; private set; }
        public Point End { get; private set; }
        public Line(Point start, Point end) 
        {
            shapeType = ShapeType.Line;
            Start = start;
            End = end;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Start: ({Start.X}, {Start.Y}), End: ({End.X}, {End.Y})");
        }
    }
}

