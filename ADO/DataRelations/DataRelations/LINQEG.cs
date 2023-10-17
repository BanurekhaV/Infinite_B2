using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRelations
{
    class LINQEG
    {
        
        static void Main()
        {
            //AggregateFunctions.fncount();
            //AggregateFunctions.Aggregate1();
            //AggregateFunctions.Aggregate2();
            // ElementsAtOperations.Element_At();
            // ElementsAtOperations.First_operator();
            //ElementsAtOperations.Last_operator();
            // ElementsAtOperations.Single_Operator();
          //  ElementsAtOperations.OrderListEg();
            ElementsAtOperations.GrpBy();
            Console.Read();
        }
    }

    class ElementsAtOperations
    {
        public static void Element_At()
        {
            string[] flowers = { "Rose", "Lily", "Jasmine", "Marigold", "Hibiscus" };
            Console.WriteLine(flowers.ElementAt(4));
            //Console.WriteLine(flowers.ElementAt(5)); // throws an exception (index out of range)
            Console.WriteLine(flowers.ElementAtOrDefault(5));
        }

        public static void First_operator()
        {
            string[] flowers = { "Rose", "Lily", "Jasmine", "Marigold", "Hibiscus" };
            Console.WriteLine(flowers.First());
            string[] empty = { };
            Console.WriteLine(empty.FirstOrDefault());
        }

        public static void Last_operator()
        {
            string[] flowers = { "Rose", "Lily", "Jasmine", "Marigold", "Hibiscus" };
            Console.WriteLine(flowers.Last());
            string[] empty = { };
            Console.WriteLine(empty.LastOrDefault());
        }
        public static void Single_Operator()
        {
            string[] names1 = { "Rajnikanth" };
            string[] names2 = { "Narendra Modi", "JoeBiden", "Donald Trump", "Obama" };
            string[] empty = { };
            Console.WriteLine(names1.Single());
          //  Console.WriteLine(names2.Single()); //throws exception
          //  Console.WriteLine(empty.Single()); // throws exception
            Console.WriteLine(empty.SingleOrDefault());
            Console.WriteLine(names1.SingleOrDefault());
            //  Console.WriteLine(names2.SingleOrDefault()); // throw exception (more elements)

            //sort the collection
            var sortednames = names2.OrderBy(n => n);
            foreach(var v in sortednames)
            {
                Console.WriteLine(v);
            }
           
        }

        public static void OrderListEg()
        {
            string[] capitals = { "Delhi", "Ambal", "Mumbai", "Agra","Bangalore", "Nagpur","Hydereabad", "abcd", "Chennai" };

            var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);
            foreach(var v in result)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("------------------");
             result = capitals.OrderByDescending(c => c.Length).ThenByDescending(c => c);

            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
        }

        public static void GrpBy()
        {
            int[] numbers = { 10, 15, 20, 25, 30, 35, 42 };

            var result = numbers.GroupBy(num => (num % 10 == 0));

            foreach(IGrouping<bool,int> grp in result)
            {
                if(grp.Key==true)
                {
                    Console.WriteLine("Group 1 - Divisible by 10");
                }
                else
                    Console.WriteLine("Group 2 - Not Divisible by 10");

                foreach(int n in grp)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
    class AggregateFunctions
    {
       public static void fncount()
        {
            string[] colors = { "Red", "Blue", "Pink", "Yellow", "Orange", "White" };
            var count = colors.Count();

            int[] numbers = { 23, 2, 34, 56, 78, 45 };
            var maxnum = numbers.Max();
            Console.WriteLine($"Count is {count} and max is {maxnum}");
        }

        //aggregation by simple accumulation
        public static void Aggregate1()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 }; //{2,3,4,5} {6,4,5} {24,5}{120}
            var result = numbers.Aggregate((x, y) => x * y);
            Console.WriteLine("Aggregated numbers by multiplication :{0}", result);
        }

        //aggregation with seed value
       public static void Aggregate2()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var result = numbers.Aggregate(10, (x, y) => x * y);
            Console.WriteLine(result);
        }
    }
}
