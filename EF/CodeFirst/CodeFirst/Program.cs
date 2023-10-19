using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Model;


namespace CodeFirst
{
    class Program
    {
        static PersonContext pc = new PersonContext();
        static void Main(string[] args)
        {
            SelectPerson();
            Console.WriteLine("--------------------");
            AddPerson();
            SelectPerson();
            Console.Read();
        }

        public static void SelectPerson()
        {
            using(var db= new PersonContext())
            {
                var persondetails = db.Persons.ToList();

                foreach(var p in persondetails)
                {
                    Console.WriteLine($"{ p.PersonId}, {p.FirstName}, {p.LastName} , {p.BirthDate}");
                }
            }
        }

        public static void AddPerson()
        {
            var person = new Person
            {
                LastName = "Kumar",
                FirstName = "Kishore",
                BirthDate = DateTime.Now
            };
            pc.Persons.Add(person);
            pc.SaveChanges();

        }
    }
}
