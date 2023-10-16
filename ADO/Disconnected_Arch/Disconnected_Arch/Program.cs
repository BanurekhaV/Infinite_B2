using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Disconnected_Arch
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con;
            SqlDataAdapter da;
            try
            {
                con = new SqlConnection("Data Source=Laptop-tjj7d977; initial Catalog=Northwind;" +
                    "trusted_connection=true;");
                da = new SqlDataAdapter("select * from region", con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "nRegion");
                DataTable dt = ds.Tables["nRegion"];

                //to access the data in the datatable 
                foreach(DataRow drow in dt.Rows)
                {
                    foreach(DataColumn dcol in dt.Columns)
                    {
                        Console.Write(drow[dcol]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            Console.Read();
        }
    }
}
