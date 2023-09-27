using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace DI_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer uc = new UnityContainer();

            //register all relevant types
           // uc.RegisterType<BusinessLayer.BusinessLayer>();
           // uc.RegisterType<DataLayer.DataLayer>();
          
            uc.RegisterType<IProducts, DataLayer.DataLayer>();
            uc.RegisterType<IOrders, Implementors.OrdersClass>();

            //invoking the DI enabled methods
            BusinessLayer.BusinessLayer bl = uc.Resolve<BusinessLayer.BusinessLayer>();
            bl.Insert();
            Console.Read();
        }
    }
}
