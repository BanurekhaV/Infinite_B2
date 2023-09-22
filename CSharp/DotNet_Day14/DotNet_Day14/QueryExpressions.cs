using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day14
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }

        //populate student details
        public static List<Student>GetStudents()
        {
            List<Student> stdlist = new List<Student>()
            {
                new Student{ID=101, Name="Bhavagna",Class="12"},
                new Student{ID=102, Name="Arpitha",Class="12"},
                new Student{ID=103, Name="Deepika",Class="11"},
                new Student{ID=104, Name="Muthu",Class="10"},
            };
            return stdlist;
        }
    }
    class QueryExpressions
    {
       public static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //query expression
            var oddnos = from n in numbers
                         where (n % 2) != 0
                         select n;
            //iterate the fetched collection/IEnumerable
            foreach(var i in oddnos)
            {
                Console.WriteLine(i);
            }

            IEnumerable<string> sname = from s in Student.GetStudents()
                                        where s.ID == 102
                                        select s.Name;

            foreach(var s in sname)
            {
                Console.WriteLine("The name of the student {0}",s);
            }

            
            Console.Read();
        }
    }
}
