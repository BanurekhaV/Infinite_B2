using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day8
{
    abstract class Shapes
    {
        const float pi = 3.14f;
        //declare an abstract method w/o implementation
        abstract public int Area();
        abstract public void Show(string s);

        //non-abstract method with implementation
        public virtual void ShowShape()
        {
            Console.WriteLine("Shape");
        }
        
    }

    class Square : Shapes
    {
        int side = 0;

        public Square(int x)
        {
            side = x;
        }
        public override int Area()
        {
            return side * side;
        }

        public override void Show(string s)
        {
            Console.WriteLine(s);
        }

        public override void ShowShape()
        {
            base.ShowShape();
            Console.WriteLine("Shape thru Square class");
        }
    }

    class Abstract_Eg
    {
        static void Main()
        {
            Square sq = new Square(4);
            int areaofsquare=sq.Area();
            Console.WriteLine(areaofsquare);
            Console.WriteLine(sq.Area());
            sq.ShowShape();
            sq.Show("Square");
            Shapes s = new Square(10);
            Console.WriteLine("--------------");
            Console.WriteLine(s.Area());
            Console.Read();
        }
    }
}
