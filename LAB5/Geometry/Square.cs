using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5.Geometry
{
    class Square : Paralegram
    {
        public Square() : base() { }
        public Square(Point p1, Point p2, Point p3, Point p4) : base(p1, p2, p3, p4) { }
        public Square(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
            : base(x1, y1, x2, y2, x3, y3, x4, y4) { }
        public double GetLineLength()
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }
        public double GetPerimeter()
        {
            return 4 * Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }
        public double GetSquare()
        {
            return Math.Pow(Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2)), 2);
        }
    }
}
