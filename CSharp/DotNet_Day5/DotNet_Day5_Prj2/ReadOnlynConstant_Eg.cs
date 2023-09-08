using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day5_Prj2
{
    class ReadOnlynConstant_Eg
    {
        public readonly int var1; //decl. a readonly variable
        public readonly int var2 = 15;

        const float PI=3.14f; //need to be initialized during declaration

       public ReadOnlynConstant_Eg(int x, int y)
        {
            var1 = x;
            var2 = y;
            Console.WriteLine("Var 1 is {0} and Var2 is {1}", var1,var2);
        }

        public ReadOnlynConstant_Eg(int a)
        {
            var1 = a;
            Console.WriteLine("Var 1 is {0} and Var2 is {1}", var1, var2);
        }

        public void ChangeReadOnly()
        {
            
        }

    }
}
