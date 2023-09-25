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
            // DisplayArea(c);
            DisplayAreawithSwitch(c);
            Rectangle r = new Rectangle(2, 5);
          //  DisplayArea(r);
            DisplayAreawithSwitch(r);
            Rectangle sq = new Rectangle(4, 4); //area of square as the l and b are same
            DisplayAreawithSwitch(sq);
            Triangle t = new Triangle(2, 3);
            //  DisplayArea(t);
            DisplayAreawithSwitch(t);
            Console.Read();
        }

        public static void DisplayArea(Shapes shape)
        {
            if(shape is Circle c)
            {
               // Circle circle = (Circle)shape;
               // Console.WriteLine("Area of Circle is :{0}", circle.Radius * circle.Radius * Shapes.PI);
                Console.WriteLine("Area of Circle is :{0}", c.Radius * c.Radius * Shapes.PI);
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

        static void DisplayAreawithSwitch(Shapes shape)
        {
            switch (shape)
            {
                case Circle c:
                    Console.WriteLine("Circles Area..");
                    break;

                case Rectangle r when r.Length == r.Breadth:
                    Console.WriteLine("Area of Square :{0}", r.Breadth * r.Length);
                    break;
                case Rectangle r:
                    Console.WriteLine("Rectangles Area {0}", r.Length*r.Breadth);
                    break;
                
                case Triangle t:
                    Console.WriteLine("Triangles Area..");
                    break;
                case null: throw new ArgumentNullException("No Argument");
                default:
                    throw new ArgumentException("invalid shape object");
                
            }
        }
    }
}
