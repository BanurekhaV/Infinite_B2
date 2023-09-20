using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DotNet_Day12
{
   // [Serializable]
   public class Books
    {
       // [System.Xml.Serialization.XmlElement("AuthorName")]
        public string authorname;
       // [System.Xml.Serialization.XmlElement("BookName")]
        public string bookname;
       // [System.Xml.Serialization.XmlElement("YearPublished")]
        public int yearpublished;

        public Books() { }

        public Books(string aname, string bname, int yr)
        {
            this.authorname = aname;
            this.bookname = bname;
            this.yearpublished = yr;
        }
    }
    class XMLSerialization
    {
        static void Main()
        {
            Books book = new Books("Amish Tripathi", "The Immortals of Meluha", 2009);

            //Serialize to xml document
            XmlSerializer xmlser = new XmlSerializer(typeof(Books));
            StreamWriter writer = new StreamWriter("Books1.xml");
            xmlser.Serialize(writer.BaseStream, book);
            writer.Close();
            //  xmlser.Serialize(Console.Out, book);

            //Deserialize from xml document

            Books b1 = new Books();
            XmlSerializer x1 = new XmlSerializer(typeof(Books));
            StreamReader reader = new StreamReader("Books1.xml");
            object obj = x1.Deserialize(reader.BaseStream);
            b1 = (Books)obj;
            reader.Close();
            Console.WriteLine("---------------");
            Console.WriteLine(b1.authorname + "  "+ b1.bookname + " " + b1.yearpublished);
           
            Console.Read();
        }
    }
}
