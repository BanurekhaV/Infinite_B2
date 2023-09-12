using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day7
{
    class Shape
    {
        protected float R = 1.5f, L, B;

        public virtual float Area() //by using virtual keyword, the class marks the 
        {                               
                          // function to be overridden in the derived classes
       
            return 3.14f * R * R;  
        }

        public virtual float Circumference()
        {
            return 2 * 3.14f * R;
        }
    }

    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.WriteLine("Enter Length :");
            L = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Breadth :");
            B = float.Parse(Console.ReadLine());
        }

       public override float Area()
        {
            GetLB();
            return L * B;
        }

        public override float Circumference()
        {
            GetLB();
            return 2 * (L + B);
        }

    }

    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.WriteLine("Enter Radius :");
            R = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            return 10.5f;
        }


        //the type circle has chosen not to override Area() and Circumference()
        //since the logic suits the type, and hence it can call the method as it is
    }
    class Overriding_Eg
    {
        static void Main(string[] args)
        {
            //Rectangle rectangle = new Rectangle();
            //rectangle.GetLB();

            //Console.WriteLine("Area of Rectangle is {0}", rectangle.Area());
            //Console.WriteLine("Circumference of the Rectangle is {0}", rectangle.Circumference());

            //Console.WriteLine("------------");
            //Circle circle = new Circle();
            //circle.GetRadius();
            //Console.WriteLine("Area of Circle is {0}", circle.Area());
            //Console.WriteLine("Circumference of Circle is {0}", circle.Circumference());
            Console.WriteLine("==================");
            //in order to exhibit polymorphic behaviour, we have to use the concept of co-variance
            Shape shape = new Shape();
            Console.WriteLine("Shape Class Details ..");
            Console.WriteLine(shape.Area());
            Console.WriteLine(shape.Circumference()); 
            Console.WriteLine("Rectangles Details..");
            shape = new Rectangle(); //when the app. expects shape type, we are providing rectangle type
            Console.WriteLine("Area of Rectangle : {0}",shape.Area());
            Console.WriteLine("Circumference of Rectangle {0}",shape.Circumference());
            Console.WriteLine("Circles Details ..");
            shape = new Circle(); //when the app. expects shape type, we are providing rectangle type
            Console.WriteLine("Area of Circle : {0}", shape.Area());
            Console.WriteLine("Circumference of Circle {0}", shape.Circumference());
            Console.Read();
        }
    }
}
