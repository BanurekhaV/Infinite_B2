using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day11
{
    class Disposable_Eg : IDisposable
    {
        //constructor
        public Disposable_Eg()
        {
            Console.WriteLine("Allocating Resources...");
        }

        public void DoSomething()
        {
            Console.WriteLine("Using Resources for application..");
        }
        public void Dispose()
        {
            Console.WriteLine("Releasing Resources..");
        }

        static void Main()
        {
            Console.WriteLine("Disposable Example 1...");
            using(var disobj= new Disposable_Eg())
            {
                disobj.DoSomething();
            }  // the using block will call the dispose() automatically

            Console.WriteLine("Disposable Example 2...");

            using (StreamReader sr = new StreamReader(@"C:\Banu\Infinite\B2\Git basics.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
                Console.Read();
        }
    }
}
