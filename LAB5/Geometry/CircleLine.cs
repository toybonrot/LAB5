using LAB5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5.Geometry
{
    class CircleLine : GeometryFigure, ILineFigure/*, IColor*/
    {
        public Point mp { get; set; }
        public double r { get; set; }
        ConsoleColor color;
        public CircleLine()
        {
            mp = new Point();
            r = 0;
            color = ConsoleColor.Green;
        }

        public CircleLine(Point mp, double r)
        {
            this.mp = mp;
            this.r = r;
            color = ConsoleColor.Green;
        }
        public override void Show()
        {
            Console.Write("CircleLine:\nmp = ");
            mp.Show();
            Console.WriteLine($"r = {r}");
        }
        public double GetLength()
        {
            return 2 * Math.PI * r;
        }
    }
}
