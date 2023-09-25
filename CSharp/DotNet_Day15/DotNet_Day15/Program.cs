using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day15
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new List<double>() { 10, 20, 30, 40, 50 };

            //1.
            //Tuple<int, double> t = Calculate(values);
            //2. 
            var t = Calculate(values);
         //1 and 2
         Console.WriteLine($"There are : {t.Item1} values and their Sum is {t.Item2}");

            //3.
            Console.WriteLine($"There are :{t.count} values and their Sum is {t.sum}");
            //4. 

            var (CountReceive, SumReceive) = Calculate(values);
            Console.WriteLine($"There are {CountReceive} values and their Sum is : {SumReceive}");
            Console.Read();
        }

        //1. static Tuple<int,double> Calculate(IEnumerable<double> val)
        //2.
       // static (int,double)Calculate(IEnumerable<double> val)

        //3.
       public static (int count, double sum)Calculate(IEnumerable<double>val)
        {
            int count = 0;
            double sum = 0;
            
            foreach(var v in val)
            {
                count++;
                sum += v;
            }
            //in order to return multiple values thru tuple object, we need to
            //create an object of the tuple classes create()
            //1. Tuple<int, double> tp = Tuple.Create(count, sum);

            //return the tuple instance
            //1.  return tp;

            //2.
            return (count, sum);
        }
    }
}
