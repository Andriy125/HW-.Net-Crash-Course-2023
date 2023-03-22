using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11__07._03._23_
{
    internal class Rectangle : Shape
    {
        public Point TopLeft { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(Point topLeft, int width, int height)
        {
            shapeType = ShapeType.Rectangle;
            TopLeft = topLeft;
            Width = width;
            Height = height;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"TopLeft: ({TopLeft.X}, {TopLeft.Y}), Width: {Width}, Height: {Height}");
        }
    }
}
