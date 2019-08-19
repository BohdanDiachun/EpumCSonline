using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int _x = 0, int _y = 0)
        {
            X = _x;
            Y = _y;
        }
    }


    public static class Rectangle
    {      
        public static int getPerimeter(Point topLeft, Point botRight)
        {
            return 2 * (botRight.X - topLeft.X + topLeft.Y - botRight.Y);
        }

        public static int getArea(Point topLeft, Point botRight)
        {
            return (botRight.X - topLeft.X) * (topLeft.Y - botRight.Y);
        }
    }

    public static class Circle
    {
        const double PI = 3.1415;
   
        public static double getLength(int radius)
        {
            return 2 * PI * radius;
        }

        public static double getArea(int radius)
        {
            return PI * radius * radius;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Point topLeft = new Point();
            Point botRight = new Point();

            Console.Write("Enter top left X: ");
            topLeft.X = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter top left Y: ");
            topLeft.Y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter bottom right X: ");
            botRight.X = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter bottom right Y: ");
            botRight.Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Perimeter: {Rectangle.getPerimeter(topLeft, botRight)}");
            Console.WriteLine($"Area: {Rectangle.getArea(topLeft, botRight)}");

            Console.WriteLine("=======================");

            Console.Write("Enter circle radius: ");
            int radius = Convert.ToInt32(Console.ReadLine());
     
            Console.WriteLine($"Circle length: {Circle.getLength(radius)}");
            Console.WriteLine($"Circle area: {Circle.getArea(radius)}");

            Console.ReadKey();
        }
    }
}
