using LAB5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5.Geometry
{
    class Line : GeometryFigure, ILineFigure/*, IColor*/
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        ConsoleColor color;
        public Line()
        {
            p1 = new Point();
            p2 = new Point();
            color = ConsoleColor.Blue;
        }
        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            color = ConsoleColor.Blue;
        }
        public override void Show()
        {
            Console.WriteLine("Line:\np1 = , p2 = ");
            p1.Show();
            Console.WriteLine("p2 = ");
            p2.Show();
        }
        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }
    }
}
