using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day7
{
    class Parent1 { 
    
    }

    class Parent2 : Parent1
    {
       public static Parent1 TestMethod(Parent1 p1)
        {
            return new Parent1();
        }
    }

    class ContraVarianec_Eg
    {
        static void Main()
        {
            Parent2 p2 = new Parent2();
            Parent2.TestMethod(p2);  //contravariance, supplying a derived type when the argument is expected to be of
                                     //base type
        }
    }
}
