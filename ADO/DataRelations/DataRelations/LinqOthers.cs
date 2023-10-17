using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRelations
{
    class Person
    {
        public int Pid { get; set; }
        public string PName { get; set; }
    }

    class Course
    {
        public int CId { get; set; }
        public string CName { get; set; }
    }
    class LinqOthers
    {
        public static void GrpJoinEg()
        {
            Person[] p = new Person[]
            {
            new Person{Pid=1,PName="Shubangi"},
            new Person{Pid=2,PName="Shilpa"},
            new Person{Pid=2,PName="Shahbaz"},
            new Person{Pid=1,PName="Sowmya"},
            new Person{Pid=3,PName="Sahithi"},
            };

            Course[] c = new Course[]
            {
            new Course{CId=1,CName="ADO.Net"},
               new Course{CId=2,CName="cSharp.Net"},
                  new Course{CId=5,CName="SQL"},
            };

            var result = c.GroupJoin(p, crs => crs.CId, pers => pers.Pid, (cr, pr) => new
            {
                Key = cr.CName,
                p = pr
            });
            Console.WriteLine("Group-Joined List of Persons who have either taken ADO or C#.Net");
            foreach(var course in result)
            {
                foreach(var per in course.p)
                {
                    Console.WriteLine(course.Key + " "+ per.PName );
                }
            }
        }

        public static void SimpleJoin()
        {
            string[] str1 = { "India", "Japan", "US", "Korea", "Russia" };
            string[] str2 = { "China", "Korea", "Israil", "UK", "India", "Japan" };

            var result = str1.Join(str2, s1 => s1, s2 => s2, (s1, s2) => s1);
            Console.WriteLine("Post Join Operation");
            foreach(var country in result)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine("-------------------");

            string[] warmcountries = { "Turkey", "Italy", "Spain", "Saudi Arabia", "Etiopia" };
            string[] europeancountries = { "Spain", "Denmark", "Germany", "Italy", "Portugal" };

            result = warmcountries.Join(europeancountries, warm => warm, eur => eur, (warm,eur) => eur);

            foreach(var c in result)
            {
                Console.WriteLine(c);
            }
        }
        static void Main()
        {
            //GrpJoinEg();
            SimpleJoin();
            Console.Read();
        }

    }
}
