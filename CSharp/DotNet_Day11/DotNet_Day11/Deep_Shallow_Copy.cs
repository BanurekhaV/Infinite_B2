using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day11
{
    class Person
    {
        public int Age;

        public PersonDescription desc;

        public Person(int a, string f, string l)
        {
            Age = a;
            desc = new PersonDescription(f, l);
        }

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person dcopy = new Person(this.Age, desc.FirstName, desc.LastName);
            return dcopy;
        }
    }

    class PersonDescription
    {
        public string FirstName;
        public string LastName;

        public PersonDescription(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }
    }
    class Deep_Shallow_Copy
    {
        static void Main()
        {
            Person p1 = new Person(20, "Amithabh", "Bacchan");
            Person p2 = (Person)p1.ShallowCopy(); //clonned object
            Console.WriteLine(p1.Age + " " + p1.desc.FirstName + " " +p1.desc.LastName);

            Console.WriteLine(p2.Age + " " + p2.desc.FirstName + " " + p2.desc.LastName);
            p2.desc.LastName = "Ganguly";
            Console.WriteLine(p1.desc.LastName);
            Console.WriteLine(p2.desc.LastName);

            Console.WriteLine("------Deep Copy-------");

            Person p3 = p1.DeepCopy();
            Console.WriteLine($"P3's Age {p3.Age}, p3's FName {p3.desc.FirstName} and p3's LName {p3.desc.LastName}");

            p3.desc.FirstName = "Roopa";

            Console.WriteLine(p1.desc.FirstName);
            Console.WriteLine(p3.desc.FirstName);
            Console.Read();
            
        }
    }
}
