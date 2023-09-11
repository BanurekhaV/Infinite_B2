using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day6
{
    class Products
    {
        public int Pid;
        public string Name;
        public static float Price = 246;
        //instance constructor
        public Products(int id, string name)
        {
            this.Pid = id;
            this.Name = name;
        }

        //static constructor that 
        static Products()
        {
            Price = 500;
        }

        public void Display()
        {
            Console.WriteLine($"{Pid}, {Name}, {Price}");
        }
    }
    class static_Constructor
    {
        public static void Main()
        {
            Products p1 = new Products(100, "Pens");
            p1.Display();
            Products p2 = new Products(200, "Erasers");
            p2.Display();
            Console.Read();
        }
    }
}
