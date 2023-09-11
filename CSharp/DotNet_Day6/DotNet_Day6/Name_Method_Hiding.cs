using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day6
{
    class BaseClass
    {
        public int data1;

        public void MethodHide(string s)
        {
            Console.WriteLine("Message from Base class {0}", s);
        }
    }

    class DerivedClass : BaseClass
    {
        new int data1; // this is name hiding, where we are hiding the member from the base class
                       //since we would want to use the same typed and same named field
   
        public DerivedClass(int x, int y) 
        {
            base.data1 = x;  //data1 of base class
            data1 = y;     //data1 of derived class           
        }

        public new void MethodHide(string s2)  //method hiding
        {
            Console.WriteLine("Message from Child class {0}", s2);
        }

        public void ShowData()
        {
            Console.WriteLine($"Base class Data1 :{base.data1} and Derived class Data 1 :{data1}");
        }
    }
    class Name_Method_Hiding
    {
        public static void Main()
        {
            //DerivedClass dc = new DerivedClass(1, 2);
            //dc.ShowData();
            //dc.MethodHide("DC");
            BaseClass bc = new BaseClass();
            bc.MethodHide("Base "); //base classes method
            bc = new DerivedClass(5, 6); //Co-Variance
            bc.MethodHide("derived"); // should be derived classes method

            Console.WriteLine("Constructor Chaining with 'this'");
            Constructor_Chain cc = new Constructor_Chain(50000);
            cc.ShowData();
            Console.Read();
        }
    }
}
