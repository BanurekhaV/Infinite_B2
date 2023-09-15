using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day9
{
    class Important_Interfaces
    {
        static void Main()
        {
            //List Initializers
            List<string> WeekDays = new List<string>()
            {
                "Sunday","Monday","Tuesday","Wednesday","Thursday",
                "Friday","Saturday"
            };

            foreach(var v in WeekDays)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("-----Using IEnumerable-------");
            //let us create IEnumerable of string
            IEnumerable<string> ies = WeekDays;

            foreach(string wd in ies)
            {
                Console.WriteLine(wd);
            }

            Console.WriteLine("------UsingIEnumerator-----");
                                                 //to convert list into IEnumerator, so that we can invoke getenumerator()
            IEnumerator<string> enumerator = WeekDays.GetEnumerator();

            //now to iterate the enumerator, we use movenext()
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.Read();
        }
    }
}
