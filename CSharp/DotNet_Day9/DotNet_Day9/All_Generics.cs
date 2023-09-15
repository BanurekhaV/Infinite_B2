using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day9
{
    //generic class
    class All_Generics<T>
    {
        //generic field
        private T genericfield;
        public T prop2 { get; set; }  //_prop2 field

        //generic constructor
        public All_Generics(T val)
        {
            genericfield = val;
            Console.WriteLine(genericfield);
        }
        //generic property
        public T genericProperty
        {
            get
            { return genericfield; }
            set
            {
                genericfield = value;
            }
        }

        //generic method
        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter Types is :{0}, Value : {1}", typeof(T).ToString(),genericParameter);
            Console.WriteLine("Return Type is : {0}, Value is : {1}", typeof(T).ToString(),genericfield);
            return genericfield;
        }
    }

    class TestAllGenerics
    {
        static void Main()
        {
            All_Generics<int> intgenerics = new All_Generics<int>(10);

            Console.WriteLine(intgenerics.genericMethod(100));

            Console.WriteLine("------------");
            intgenerics.genericProperty = 20;
            Console.WriteLine(intgenerics.genericMethod(200));
            //   Console.WriteLine(intgenerics.genericProperty);

            intgenerics.prop2 = 5;
            Console.WriteLine(intgenerics.prop2);

            Console.WriteLine("++++++++++++++++++");
            All_Generics<string> strgenerics = new All_Generics<string>("Hi Generics");
            strgenerics.genericMethod("Learning Generics..");
            strgenerics.genericProperty = "Trying All Generics Example";

            strgenerics.genericMethod("Understanding Generics");

            strgenerics.prop2 = "this is automatic";
            Console.WriteLine(strgenerics.prop2);
            Console.Read();
        }
    }
}
