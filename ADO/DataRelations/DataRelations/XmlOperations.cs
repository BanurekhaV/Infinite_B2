using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;

namespace DataRelations
{
    class XmlOperations
    {
        static void Main()
        {
            //XmlWriter();
           // XmlReader();
            XmlSchemaWriter();
            XmlSchemaReader();
            Console.Read();                
        }

        static void XmlWriter()
        {
            try
            {
                DataSet ds = new DataSet("DS");
                ds.Namespace = "StdNameSpace";
                DataTable stdtable = new DataTable("Student");
                DataColumn col1 = new DataColumn("Name");
                DataColumn col2 = new DataColumn("Address");
                stdtable.Columns.Add(col1);
                stdtable.Columns.Add(col2);

                ds.Tables.Add(stdtable);

                DataRow dr = stdtable.NewRow();
                dr["Name"] = "Shilpa";
                dr["Address"] = "Vizag";

                stdtable.Rows.Add(dr);

                dr = stdtable.NewRow();
                dr["Name"] = "Arpitha";
                dr["Address"] = "Chennai";

                stdtable.Rows.Add(dr);

                dr = stdtable.NewRow();
                dr["Name"] = "Anshika";
                dr["Address"] = "Blore";

                stdtable.Rows.Add(dr);

                dr = stdtable.NewRow();
                dr["Name"] = "Tejaswini";
                dr["Address"] = "Hyderabad";

                stdtable.Rows.Add(dr);

                ds.AcceptChanges();

                //create stream writer to write the dataset data
                System.IO.StreamWriter sw = new
                    System.IO.StreamWriter("studentdata.xml");

                ds.WriteXml(sw);  // writes the data in an xml format
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           // return;
        }


        static void XmlReader()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("studentdata.xml");  // fills the dataset with data

            foreach(DataTable t in ds.Tables)
            {
                Console.WriteLine(t);
                for (int i = 0; i < t.Columns.Count; i++)
                    Console.Write("\t " + "\t" + t.Columns[i].ColumnName);
                Console.WriteLine();
                foreach(var row in t.AsEnumerable())
                {
                    for(int i=0; i<t.Columns.Count;i++)
                    {
                        Console.Write("\t" + "\t" + row[i]);
                    }
                    Console.WriteLine();
                }
            }
        }
        static void XmlSchemaWriter()
        {
            try
            {
                DataSet ds = new DataSet("DS");
                ds.Namespace = "StdNameSpace";
                DataTable stdtable = new DataTable("Student");
                DataColumn col1 = new DataColumn("Name");
                DataColumn col2 = new DataColumn("Address");
                stdtable.Columns.Add(col1);
                stdtable.Columns.Add(col2);

                ds.Tables.Add(stdtable);

                DataRow dr = stdtable.NewRow();
                dr["Name"] = "Shilpa";
                dr["Address"] = "Vizag";

                stdtable.Rows.Add(dr);

                dr = stdtable.NewRow();
                dr["Name"] = "Arpitha";
                dr["Address"] = "Chennai";

                stdtable.Rows.Add(dr);

                dr = stdtable.NewRow();
                dr["Name"] = "Anshika";
                dr["Address"] = "Blore";

                stdtable.Rows.Add(dr);

                dr = stdtable.NewRow();
                dr["Name"] = "Tejaswini";
                dr["Address"] = "Hyderabad";

                stdtable.Rows.Add(dr);

                ds.AcceptChanges();

               // XmlTextWriter writer = new XmlTextWriter(Console.Out);
                // ds.WriteXmlSchema(writer);
                ds.WriteXmlSchema("StudentSchema.xsd");  // writes only the schema behind the data and not the data
                Console.Read();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void XmlSchemaReader()
        {
            DataSet ds = new DataSet("MyData");
            //read the xml schema
          
            System.IO.StreamReader xmlreader = new System.IO.StreamReader("StudentSchema.xsd");
            
            ds.ReadXmlSchema(xmlreader);
            XmlTextWriter writer = new XmlTextWriter(Console.Out);
            ds.WriteXmlSchema(writer);
            Console.Read();
        }
    }
}
