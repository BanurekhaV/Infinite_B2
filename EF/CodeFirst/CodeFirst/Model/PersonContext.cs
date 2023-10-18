using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst.Model
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("name=PersonContext")
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
