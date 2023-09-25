extern alias L1;
extern alias L2;

using System;
using System.Collections.Generic;

namespace DotNet_Day15
{
    class Extern_Aliases
    {
        int mydata;
        static void Main()
        {
            L1.ClassLibrary1.Class1 c1 = new L1.ClassLibrary1.Class1();
            c1.Message();
            L2.ClassLibrary2.Class1 c2 = new L2.ClassLibrary2.Class1();
            c2.Message();

            Extern_Aliases ea = null; 
            ea.mydata = 6;
            Console.WriteLine(ea.mydata); //throws nullreference exception
            Console.Read();
        }        
       
    }
}
