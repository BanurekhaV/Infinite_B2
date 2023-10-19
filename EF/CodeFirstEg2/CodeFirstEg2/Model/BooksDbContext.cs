using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstEg2.Model
{
    class BooksDbContext : DbContext
    {
        public BooksDbContext():base("name=BooksContext")
        {

        }

        public DbSet<Authors>Author { get; set; }
        public DbSet<Books>Book { get; set; }
            
    }
}
