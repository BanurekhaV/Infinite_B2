using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day14
{
    class LambdaExpressions
    {
        static readonly Random random = new Random();
        static void Main()
        {
            List<int> numlist = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 9, 17, 34 };

            //to display the above collection
            foreach(int i in numlist)
            {
                Console.WriteLine(i);
            }

            //using lambda expression, we are going to find the squares
            IEnumerable<int> square = numlist.Select(x => x * x);

            foreach(int x in square)
            {
                Console.WriteLine(x);
            }

            //exercise 1 : from the above numlist,
            //using lambda exp find all the numbers divisible by 3
            //and display them 
            // ex : 2 yield break

            Student stud = Student.GetStudents().Find(std => std.ID == 102);
            Console.WriteLine(stud.ID + " "+ stud.Name + " "+stud.Class);

            Console.WriteLine("--------Yield Break-------");
            foreach(int y in LambdaExpressions.GenerateRandomYears())
            {
                Console.WriteLine(y);
            }
            Console.Read();
        }

        public static IEnumerable<int> GenerateRandomYears()
        {
            int year;
            while(true)
            {
                year = random.Next(2000, 2023);                

                if(year % 4==0)
                {
                    Console.WriteLine("Reached a Leap Year");
                   yield break;
                   // Console.WriteLine("Good Job..");
                }
                yield return year;
            }

            Console.WriteLine("Good Job..");
        }
    }
}
