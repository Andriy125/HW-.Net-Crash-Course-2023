using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11__07._03._23_
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    internal class Shape
    {
        public ShapeType shapeType { get; set; }
        public enum ShapeType
        {
            Point, Line, Triangle, Rectangle, Polyline
        }
        public virtual void Print()
        {
            Console.WriteLine($"\nType: {shapeType}");
        }
    }
}
