using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day9
{
    //generic class
    class Student<T> where T:class   //generic constraint
    {
        //generic member/field
        T PhoneNumber;

        //generic method
        public dynamic Total<T>(T Maths, T Science, T English)
        {
            dynamic m = Maths;
            dynamic s = Science;
            dynamic e = English;
           
            return m + s + e;
        }
    }
    class Generics_2_Eg
    {
        // example 2 for generic method

        public void Display<T>(string msg, T value)
        {
            Console.WriteLine("{0}, {1}", msg, value);
        }
         static void Main()
        {
            Student<Generics_2_Eg> stud = new Student<Generics_2_Eg>();

            double TotalMarks = stud.Total<float>(78.8f, 85.0f, 95.5f);
            Console.WriteLine("The Total marks Secured is {0}", TotalMarks);
            string Total = stud.Total<string>("AA","BB","CC");
            Console.WriteLine("The Total marks Secured is {0}", Total);

            Console.WriteLine("--------------");
            Generics_2_Eg ge2 = new Generics_2_Eg();
            ge2.Display<int>("This is Integer Invocation", 65);
            ge2.Display<string>("This is String Type", "hello");
            ge2.Display<char>("This is Character", 'A');
            Console.Read();
        }
    }
}
