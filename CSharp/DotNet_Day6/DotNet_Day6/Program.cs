using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day6
{
    class Parent
    {
         int x;
       // Parent parent = new Parent();
        //public Parent()  //empty constructor
        //{
        //    Console.WriteLine("Parent here...");
        //}

        public Parent(int a) //parameterized constructor
        {
            x = a;
            Console.WriteLine(x);
        }
    }

    class Child : Parent
    {
        int y;
        public Child(int b):base(b)
        {
            y = b;
            Console.WriteLine("Child here...");
        }

        public Child(int b, int c):base(c)
        {
            y = b;
            Console.WriteLine(y);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent(5);
            Child child = new Child(10);
            Child child2 = new Child(100, 200);
            Console.Read();
        }
    }
}
