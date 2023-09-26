using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    //Sealed to avoid inheritance, public to be able to work with the class
    //dependency class
    public sealed class Singleton
   // public class Singleton
    {
        //This variable will be incremented by 1 each time an object is created
        private static int counter = 0;
        //Instance variable which is going to store the Singleton instance

        private static Singleton sobj = null;

        //static method that returns the singleton object
        public static Singleton GetInstance()
        {
            if(sobj==null)
            {
                sobj = new Singleton();
            }
            return sobj;
        }

        //private constructor, so that it cannot be instantiated outside the class
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Values " + " " + counter.ToString());
        }

        //public methods to be accessed outside the class
        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        //class within class, nested class
        //public class DerivedSingleton : Singleton
        //{

        //}

    }

    


}
