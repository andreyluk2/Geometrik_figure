using System;

namespace Geometrik_figure
{
    class Program
    {
          abstract class Figure
        {
            public Figure(string n)
            {
                name = n;
            }
            private string name;
            public abstract void Draw();
            public abstract void Square();
            public void ShowName()
            {
                Console.WriteLine(name);
            }
        }
        class Rectangle : Figure
        {
            int width;
            int height;
            public Rectangle(int height, int width)
                : base("Rectangle")
            {
                this.width = width;
                this.height = height;
            }
            public override void Draw()
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            public override void Square()
            {
                Console.WriteLine("rectangle area {0} ", width * height);
            }
        }
        class Triangle : Figure
        {
            int length;
            int height;
            public Triangle(int length, int height)
                : base("Triangle")
            {
                this.length = length;
                this.height = height;
            }
            public override void Draw()
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write("*");
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" * ");
                    }
                    Console.WriteLine();
                }
            }
            public override void Square()
            {
                Console.WriteLine("Triangle area {0} ", 0.5 * length * height);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Rectangle myRect = new Rectangle(7, 10);
                myRect.ShowName();
                myRect.Draw();
                myRect.Square();
                Triangle myTriangle = new Triangle(6, 5);
                myTriangle.ShowName();
                myTriangle.Draw();
                myTriangle.Square();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
}
