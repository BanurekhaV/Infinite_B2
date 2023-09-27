using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Pattern.BusinessLayer
{
    class BusinessLayer
    {
        IProducts products;
        IOrders orders;

        //injecting the base type objects that implements the interface method
        //in the constructor
        public BusinessLayer(IProducts ip, IOrders io)
        {
            products = ip;
            orders = io;
        }

        public void Insert()
        {
            products.InsertProducts(); // this call actually is going to invoke
                                       // the class that implements the method (DataLayer)
            orders.DisplayOrders();  // "   "   "  " (OrdersClass)
        }

    }
}
