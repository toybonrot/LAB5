using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5.Geometry
{
    class Rhombus : Paralegram
    {
        double alpha;

        public double Alpha { get; set; }

        public Rhombus() : base()
        {
            Alpha = 0;
        }
        public Rhombus(Point p1, Point p2, Point p3, Point p4, double alpha) : base(p1, p2, p3, p4)
        {
            Alpha = alpha;
        }
        public Rhombus(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double alpha)
            : base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
            Alpha = alpha;
        }
        public double GetPerimeter()
        {
            return 4 * Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }
        public double GetSquare()
        {
            return Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2) * Math.Sin(alpha);
        }
    }
}
