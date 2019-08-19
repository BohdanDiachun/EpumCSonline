using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    interface IDrawable
    {
        void draw();
    }
   
    public class Figure : IDrawable
    {
        public int X { get; }
        public int Y { get; }

        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual void draw()
        {
            Console.WriteLine("Im Figure!");
        }

    }

    public class Square : Figure
    {
        public Square(int x, int y)
            : base(x, y)
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
        public static void DrawAll(params IDrawable[] array)
        {
            foreach (var item in array)
            {
                item.draw();
            }
        }

        static void Main(string[] args)
        {         
            Figure one, two, three;

            one = new Square(1, 2);

            two = new Rectangle(1, 2);

            three = new Figure(1, 2);

            DrawAll(one, two, three);
            
            Console.ReadKey();

        }
    }
}
