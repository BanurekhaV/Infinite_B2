using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day15
{
    public class Shapes
    {
        public const float PI = 3.14f;
    }

    public class Circle : Shapes
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    public class Rectangle : Shapes
    {
        public double Length { get; }
        public double Breadth { get; }

        public Rectangle(double len, double breadth)
        {
            Length = len;
            Breadth = breadth;
        }
    }

    public class Triangle : Shapes
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double bs, double ht)
        {
            Base = bs;
            Height = ht;
        }

    }
    class PatternMatching2
    {
        static void Main()
        {
            Shapes s = new Shapes();
            Circle c = new Circle(2.3);
            DisplayArea(c);
            Rectangle r = new Rectangle(2, 5);
            DisplayArea(r);
            Triangle t = new Triangle(2, 3);
            DisplayArea(t);
            Console.Read();
        }

        public static void DisplayArea(Shapes shape)
        {
            if(shape is Circle)
            {
                Circle circle = (Circle)shape;
                Console.WriteLine("Area of Circle is :{0}", circle.Radius * circle.Radius * Shapes.PI);
            }
            else if(shape is Rectangle)
            {
                Rectangle rect = (Rectangle)shape;
                Console.WriteLine("Area of Rectangle is :{0}", rect.Length * rect.Breadth);


            }
            else if(shape is Triangle)
            {
                Triangle t = (Triangle)shape;
                Console.WriteLine("Area of Triangle is :{0}", 0.5+t.Base*t.Height);
            }

            else
            {
                throw new ArgumentException("Invalid Shape Object", nameof(shape));
            }
        }
    }
}
