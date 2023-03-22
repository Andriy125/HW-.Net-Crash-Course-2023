using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW_11__07._03._23_.Shape;

namespace HW_11__07._03._23_
{
    internal class Polyline : Shape
    {
        public Point[] Points { get; private set; }

        public Polyline(Point[] points)
        {
            shapeType = ShapeType.Polyline;
            Points = points;
        }

        public override void Print()
        {
            base.Print();
            for (int i = 0; i < Points.Length; i++)
            {
                Console.WriteLine($"Point {i + 1}: ({Points[i].X}, {Points[i].Y})");
            }
        }
    }
}
