using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5.Geometry
{
    class Point : GeometryFigure/*, IColor*/
    {

        public double x { get; set; }
        public double y { get; set; }
        public ConsoleColor color;
        public Point()
        {
            x = 0;
            y = 0;
            color = ConsoleColor.Yellow;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            color = ConsoleColor.Yellow;
        }
        public override void Show()
        {
            Console.WriteLine($"Point: x = {x}, y = {y}");
        }

    }
}
