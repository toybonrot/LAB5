using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using LAB5.Interfaces;
using LAB5.Geometry;

namespace LAB5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.Show();
            Square square = new Square();
            square.Show();
            Fourangles fourangles = new Fourangles(1, 2, 3, 4, 4, 4, 3, 2);
            fourangles.Show();
            Console.WriteLine("Периметр: " + fourangles.GetPerimeter());
            Console.WriteLine("Площа:" + fourangles.GetSquare());
            Paralegram square2 = new Paralegram(1, 4, 1, 0, 5, 0, 5, 4);
            Point p1 = new Point(1, 4);
            Point p2 = new Point(1, 0);
            Point p3 = new Point(5, 0);
            Point p4 = new Point(5, 4);
            Square square3 = new Square(p1, p2, p3, p4);
            square3.Show();
            Console.WriteLine("Довжина сторони: " + square3.GetLineLength());
            Console.WriteLine("Периметр: " + square3.GetPerimeter());
            Console.WriteLine("Площа: " + square3.GetSquare());
            Rhombus romb = new Rhombus();
            romb.Show();

            Console.ReadKey(); 
        }
    }
    //interface IColor
    //{
    //    ConsoleColor GetColor();
    //    void SetColor(ConsoleColor color);
    //}
}
