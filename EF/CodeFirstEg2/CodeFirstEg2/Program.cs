using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstEg2.Model;

namespace CodeFirstEg2
{
    class Program
    {
        static BooksDbContext db = new BooksDbContext();

        static void ShowBooks()
        {
            var book = from b in db.Book
                       select b;

            foreach(var item in book)
            {
                Console.WriteLine(item.BookId + "  " + item.BookName);
            }
        }

        static void UpdateBooks(Books bk)
        {
            var book = db.Book.FirstOrDefault(b => b.BookId == bk.BookId);

            book.BookName = "Fundamentals of CSharp";
            db.SaveChanges();

          //  for delete
          //  db.Book.Remove(bk);
          //  db.SaveChanges();

        }
        static void Main(string[] args)
        {
            ShowBooks();
            Console.WriteLine("---------------");
            Books b = new Books { BookId = 1 };
            UpdateBooks(b);
            ShowBooks();
            Console.Read();
        }
    }
}
