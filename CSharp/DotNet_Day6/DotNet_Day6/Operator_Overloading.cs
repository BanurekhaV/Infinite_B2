using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day6
{

    struct Table
    {
        public int breadth;
        public int length;

        public Table(int x, int y)
        {
            breadth = x;
            length = y;
        }

        public Table(int y)
        {
            length = y;
            breadth = 10;
        }

        public void Area()
        {
            Console.WriteLine(length*breadth);
        }

    }
    class Distance
    {
        public int dist;
        public string str;
        
        public Distance(int d, string s)
        {
            dist = d;
            str = s;
        }

        public void ShowData()
        {
            Console.WriteLine("{0}, {1}", dist, str);
        }

        public static Distance operator +(Distance dt1, Distance dt2)
        {
            Distance temp = new Distance(0,null);
            temp.dist = dt1.dist + dt2.dist;
          //  temp.str = dt1.str + dt2.str;
            return temp;
        }

        public static Distance operator ++(Distance dt1)
        {
            Distance d = new Distance(0,"AA");
            d.dist= dt1.dist+1;
            return d;
        }

    }
    class Operator_Overloading
    {
        static void Main()
        {

            //int x = 7, y = 4;
            //Console.WriteLine(x + y);
            //float f1=56.7f, f2=10.5f;
            //Console.WriteLine(f1 + f2);
            //Console.WriteLine('a'+'b');
            //Console.WriteLine("Hello" + "World");

            //in order to get the same operations done as above with the objects
            //we need to overload the operator

            Distance d1, d2, d3;
            d1 = new Distance(125,"Hello");
            d2 = new Distance(150,"All");

            //we need to overload the operator '+'
            // d1.ShowData();
            // d2.ShowData();
            // d3 = d1 + d2;
            //d3 = d1++;
            //d3.ShowData();
            //d1.ShowData();

            // Table table = new Table();
            Table table = new Table(3);
            table.Area();
            Console.Read();
        }
    }
}
