using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day9
{
    //generic class
    class Student<T>
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
         static void Main()
        {
            Student<string> stud = new Student<string>();

            double TotalMarks = stud.Total<float>(78.8f, 85.0f, 95.5f);
            Console.WriteLine("The Total marks Secured is {0}", TotalMarks);
            Console.Read();
        }
    }
}
