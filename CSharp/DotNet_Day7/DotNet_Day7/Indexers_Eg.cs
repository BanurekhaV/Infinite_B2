using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day7
{
    class Books
    {
        private string[] names = new string[3];
        int bookid;

        //decl indexer
        public string this[int flag]
        {
            get {
                // string temp = names[flag];
                // return temp;
                return names[flag];
             }
            set {
                names[flag] = value;
            }
        }
    }
    class Indexers_Eg
    {
        static void Main()
        {                     
            Books books = new Books();
            books[0] = "Sydney Sheldon"; // value for the first index of the array field names
            books[1] = "Hardley Chase";
            books[2] = "Agatha Christie";
            Console.WriteLine($"{books[0]}, {books[1]}, {books[2]}");
            Console.Read();
        }
    }
}
