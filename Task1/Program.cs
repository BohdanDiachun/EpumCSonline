using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2_3
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


    public class Rectangle
    {
        Point topLeft;
        Point botRight;

        public Rectangle(Point _topLeft, Point _botRight)
        {
            topLeft = _topLeft;
            botRight = _botRight;
        }

        public int getPerimeter()
        {
            return 2 * (botRight.X - topLeft.X + topLeft.Y - botRight.Y);
        }

        public int getArea()
        {
            return (botRight.X - topLeft.X) * (topLeft.Y - botRight.Y);
        }
    }

    public class Circle
    {
        const double PI = 3.1415;
     
        public Circle()
        {     
        }

        public double getLength(int radius)
        {
            return 2 * PI * radius;
        }

        public double getArea(int radius)
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

            Rectangle myRect = new Rectangle(topLeft, botRight);

            Console.WriteLine($"Perimeter: {myRect.getPerimeter()}");
            Console.WriteLine($"Area: {myRect.getArea()}");

            Console.WriteLine("=======================");

            Console.Write("Enter circle radius: ");
            int radius = Convert.ToInt32(Console.ReadLine());

            Circle myCircle = new Circle();

            Console.WriteLine($"Circle length: {myCircle.getLength(radius)}");
            Console.WriteLine($"Circle area: {myCircle.getArea(radius)}");

            Console.ReadKey();
        }
    }
}
