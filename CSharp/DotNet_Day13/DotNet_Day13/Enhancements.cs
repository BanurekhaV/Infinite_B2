using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorDLL;
using Calculator2;
using System.Runtime.InteropServices;

namespace DotNet_Day13
{
    class Enhancements
    {
        public string name { get; set; } = "Manisha";
        static void Main()
        {
            //anonymous data type
            var myanonymousType = new
            {
                data1 = "CSharp",
                data2 = 2,
                data3 = true
            };
            Console.WriteLine(myanonymousType.GetType().ToString());

            //Literal improvements
            var lit1 = 478_127_369_844_766;  //digit seperator
            var lit2 = 0x_ea_3ef7e;
            var lit3 = 1100_1011_0110_1001;
            Console.WriteLine($"Lit 1 : {lit1}, Lit 2: {lit2}, Lit 3 : {lit3}");

            //Nullable types
            int ? i = 0;
            char ? ch = null;
            Nullable<Char> c = null;
            c = 'Y';

            if(c.HasValue) //checks if the nullable value type has valid value or not
            {
                Console.WriteLine(c.Value);
            }
            else
                Console.WriteLine(" Only Null");

            //Null Conditional Operator
            //Enhancements e = null;
            Enhancements e = new Enhancements();
           
            string nm = e?.name;
            Console.WriteLine("Name is {0}", nm);
            //referencing a dll project and accessing the class and methods of the library
            Console.WriteLine("--------------D L L ------------");
            CalculatorClass cc = new CalculatorClass();
            Console.WriteLine(cc.WelcomeFunc("Deepika"));
            Console.WriteLine("Addition : {0}",cc.Add2Nos(10,20));

            //using the extension methods with the original class object
            Console.WriteLine("Multiplication :{0}",cc.Multiply2Nos(10,20));
            Console.WriteLine("Subtraction :{0}",cc.Subtract2Nos(20,10));

            //Named and optional Parameters
            Console.WriteLine("***********************");
            NamedOptional no = new NamedOptional();
            Console.WriteLine(no.AddNumber(15,20)); // positional

            Console.WriteLine(no.AddNumber(firstnumber:20,secondnumber:15));  //named parameter
            Console.WriteLine(no.AddNumber(secondnumber:10, firstnumber:5)); // named parameter, changing the order of the parameters

            //1. Named arguments can follow positional arguments
            Console.WriteLine(no.AddNumber(2,secondnumber:5));

            //2. Positional arguments cannot follow named arguments. It throws compilation error
            //  Console.WriteLine(no.AddNumber(secondnumber:8, 10));

            Console.WriteLine("-----Default valued Parameters-----");
            Console.WriteLine(no.Add(15)); // passing just one parameter, the other will take default value
            Console.WriteLine(no.Add(15,100));  //default value will be overwritten by the passed value

            Console.WriteLine("------Optional Parameters------");
            Console.WriteLine(no.Sum(25));  // the second parameter is optional
            Console.WriteLine(no.Sum(25,25));
            Console.Read();
        }

        public void Display()
        {
            Console.WriteLine("Hi");
        }
    }

    class NamedOptional
    {
       public int AddNumber(int firstnumber, int secondnumber)
        {
            return firstnumber + secondnumber;
        }

        //default value for a parameter
        public int Add(int a, int b=5)
        {
            return a + b;
        }

        //optional parameters
      
        public int Sum(int num1, [Optional] int num2)
        {
            return num1 + num2;
        }
    }
}
