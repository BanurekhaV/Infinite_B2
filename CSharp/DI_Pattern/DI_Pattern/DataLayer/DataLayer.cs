using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Pattern.DataLayer
{
    class DataLayer : IProducts
    {
        public string InsertProducts()
        {
            string str = "DI Injected successfully..";
            Console.WriteLine(str);
            return str;
        }
    }
}
