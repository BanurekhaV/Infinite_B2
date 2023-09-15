using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day9
{
    class Comparission_eg
    {
        static void Main()
        {
            string[] fruits = { "Orange", "Banana", "Apple", "Guava" };
            Array.Sort(fruits);
            foreach (string s in fruits)
            {
                Console.WriteLine(s);
            }

            Students stud = new Students();
            stud.compareStudentsName();
            Console.WriteLine("Comparing Marks ---------");
            Marks m = new Marks();
            Students s1 = new Students() { Name = "Natasha", Totalmarks = 81 };
            Students s2 = new Students() { Name = "Aasha", Totalmarks = 86 };
            Console.WriteLine(m.Compare(s1, s2)); 
            Console.Read();
        }
    }

    class Students : IComparable
    {
        public string Name { get; set; }
        public int Totalmarks { get; set; }

        public void compareStudentsName()
        {
            //Object initialization
            Students[] studarray = new Students[]
            {
                new Students(){Name="Deepika", Totalmarks=68},
                new Students(){Name="Amarnath",Totalmarks=72},
                new Students(){ Name="HimaBindu",Totalmarks=75},
                 new Students(){ Name="Adithya",Totalmarks=70}
            };
            Array.Sort(studarray);
            foreach(var s in studarray)
            {
                Console.WriteLine(s.Name);
            }
        }

        public int CompareTo(object obj)
        {
            Students sobj = obj as Students; // (typecasting object to students)
            if(sobj !=null)
            {
                return this.Name.CompareTo(sobj.Name);
            }
            return -1;
        }
    }

    class Marks : IComparer<Students>
    {
                   
    public int Compare(Students x, Students y)
        {
             return x.Totalmarks.CompareTo(y.Totalmarks);
        }
                          
    }
}

