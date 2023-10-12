using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revision.BusinessAccess;
using Revision.DataAccess;

namespace Revision
{
    public class MyCalculator
    {
        //public static bool AreEqual(int n1, int n2)
        //{
        //    return n1 == n2;
        //}
        //public static bool AreEqual(object n1, object n2)
        //{
        //    return n1 == n2;
        //}
        public static bool AreEqual<T>(T n1, T n2)
        {
            return n1.Equals(n2);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            bool IsSame;
            // IsSame= MyCalculator.AreEqual<int>(3, 5);
            //IsSame = MyCalculator.AreEqual<string>("hello", "hello");
            IsSame = MyCalculator.AreEqual<double>(120.5, 135.6);

            if(IsSame)
            {
                Console.WriteLine("Both inputs are equal");
            }
            else
                Console.WriteLine("Both inputs are not equal");

            //delegates
            //1. associate the delegate object to a matching function
            revisiondelegate rdel = new revisiondelegate(Delegateeg.delegatehandler);
            //2. invoke the delegate to invoke the function
            rdel("Banurekha");

            //1. without generic delgates

            delfunc1 df1 = new delfunc1(Delegateeg.Addnumber1);
            delfunc2 df2 = new delfunc2(Delegateeg.Addnumber2);
            delfunclen dflen = new delfunclen(Delegateeg.CheckLength);
            double d = df1(5, 10.5f,20);
            Console.WriteLine(d);
            df2(5, 10.5f, 20);
            Console.WriteLine(dflen("Banurekha"));
            Console.WriteLine("-------using Generic Delegates--------");
            //2. with generic delegates
           // calling the function with return type using generic func delegate
           Func<int, float, double, double> funcobj = new Func<int, float, double, double>(Delegateeg.Addnumber1);
             double result = funcobj.Invoke(5, 10.5f, 20);
            Console.WriteLine(result);

            //calling the function without return type using generic action delegate 
            Action<int, float, double> actobj = new Action<int, float, double>(Delegateeg.Addnumber2);
            actobj.Invoke(5, 10.5f, 20);

            ////calling the function which returns a boolean using generic predicate delegate 
            Predicate<string> predicateobj = new Predicate<string>(Delegateeg.CheckLength);
            bool status = predicateobj.Invoke("Banu");
            Console.WriteLine(status);

            Console.WriteLine("-----Dictionary------");
            Dictionary.dictionary_Example();

            Console.WriteLine("-----Dependency Injection-----");
            EmployeeBAL ebal = new EmployeeBAL(new EmployeeDAL());
            List<Employee> act_emplist = ebal.GetEmployees();

            foreach(Employee e in act_emplist)
            {
                Console.WriteLine($"ID : {e.ID}, Name : {e.Name} and Department : {e.Department}");
            }

            Console.Read();
        }
    }
}
