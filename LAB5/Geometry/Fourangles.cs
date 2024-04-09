using LAB5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5.Geometry
{
    class Fourangles : GeometryFigure, ISolidFigure/*, IColor*/
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public Point p3 { get; set; }
        public Point p4 { get; set; }
        ConsoleColor color;

        public Fourangles()
        {
            p1 = new Point();
            p2 = new Point();
            p3 = new Point();
            p4 = new Point();
            color = ConsoleColor.Red;
        }
        public Fourangles(Point p1, Point p2, Point p3, Point p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            color = ConsoleColor.Red;
        }

        public Fourangles(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            p1 = new Point(x1, y1);
            p2 = new Point(x2, y2);
            p3 = new Point(x3, y3);
            p4 = new Point(x4, y4);
            color = ConsoleColor.Red;
        }
        public override void Show()
        {
            Console.Write("Fourangles:\np1 = ");
            p1.Show();
            Console.Write("p2 = ");
            p2.Show();
            Console.Write("p3 = ");
            p3.Show();
            Console.Write("p4 = ");
            p4.Show();
        }

        public double GetSquare()
        {
            return Math.Abs((p1.x - p2.x) * (p1.y + p2.y) + (p2.x - p3.x) * (p2.y + p3.y)
                + (p3.x - p4.x) * (p3.y + p4.y) + (p4.x - p1.x) * (p4.y + p1.y));
        }

        public double GetPerimeter()
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2) + (Math.Pow(p3.x - p2.x, 2)
                + Math.Pow(p3.y - p2.y, 2)) + (Math.Pow(p4.x - p3.x, 2) + Math.Pow(p4.y - p3.y, 2))
                + (Math.Pow(p1.x - p4.x, 2) + Math.Pow(p1.y - p4.y, 2)));
        }
    }
}
