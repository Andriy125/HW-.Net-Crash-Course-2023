using HW_11__07._03._23_;

Shape line = new Line(new Point(0, 0), new Point(10, 10));
Shape rect = new Rectangle(new Point(5, 5), 10, 20);
Shape polyline = new Polyline(new Point[] { new Point(0, 0), new Point(10, 10), new Point(20, 0) });

line.Print();
rect.Print();
polyline.Print();