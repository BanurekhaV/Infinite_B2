using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day15
{
    class Products
    {
        public string Pid { get; set; }
        public string ProdName { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
    }
    class PatternMatching
    {
        static void Main()
        {
            Products product = new Products()
            { Pid = "1", ProdName = "Pens", Price = 20, Qty = 50 };

            switch (product)
            {
                case null:
                    Console.WriteLine("it is a constant pattern");
                    break;
                case Products p when p.ProdName.StartsWith("p"):
                    Console.WriteLine("Yes it starts with P");
                    break;
                case var v: Console.WriteLine(v?.GetType().Name); 
                    break;                
            }
            Console.Read();
        }
    }

}
