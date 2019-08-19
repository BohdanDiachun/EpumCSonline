using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{ 
    public abstract class Figure
    {
        public int X { get; }
        public int Y { get; }

        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void draw();
       
    }

    public class Square : Figure
    {
        public Square(int x, int y)
            :base(x,y)
        { }

        public override void draw()
        {
            Console.WriteLine("Im Square!");
        }

    }

    public class Rectangle : Figure
    {
        public Rectangle(int x, int y)
            : base(x, y)
        { }

        public override void draw()
        {
            Console.WriteLine("Im Rectangle!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Figure one, two;

            one = new Square(1, 2);

            two = new Rectangle(1, 2);

            one.draw();
            two.draw();

            Console.ReadKey();

        }
    }
}
