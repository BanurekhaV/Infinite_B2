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

                //let us now insert one row into the dataset and then update
                // the database

               // da.Fill(ds, "nRegion"); // refreshing the data into the dataset
               
                //1. create a row under the specific data table
                DataRow row1 = ds.Tables["nRegion"].NewRow();

                //2.give values to the new row and column
                Console.WriteLine("Enter Region Id and Region Description :");
                int rid = Convert.ToInt32(Console.ReadLine());
                string desc = Console.ReadLine();
                row1["RegionID"] = rid;
                row1["RegionDescription"] = desc;

                //3. adding the new row to the datatable
                ds.Tables["nRegion"].Rows.Add(row1);

                //4. update the database to effect the inserted row
                SqlCommandBuilder scb = new SqlCommandBuilder(da);
                da.InsertCommand = scb.GetInsertCommand();
                da.Update(ds, "nRegion");
                Console.WriteLine("---------After Insertion----------");
                da.Fill(ds, "nRegion");
                dt = ds.Tables["nRegion"];

                foreach(DataRow drow1 in dt.Rows)
                {
                    foreach(DataColumn dcol1 in dt.Columns)
                    {
                        Console.Write(drow1[dcol1]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }


                //adding one more table to the dataset
                Console.WriteLine("------------");
                da = new SqlDataAdapter("Select * from Shippers",con);
                da.Fill(ds, "nShipper");
                dt = ds.Tables["nShipper"];

                //to access the data in the datatable 
                foreach (DataRow drow in dt.Rows)
                {
                    foreach (DataColumn dcol in dt.Columns)
                    {
                        Console.Write(drow[dcol]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                //calling a stored procedure
                Console.WriteLine("------Stored Procedure call-------");
                SqlDataAdapter da1 = new SqlDataAdapter("[Ten Most Expensive Products]", con);
                da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                foreach(DataRow r in dt1.Rows)
                {
                    foreach(DataColumn c in dt1.Columns)
                    {
                        Console.Write(r[c]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            Console.Read();
        }

        
    }
}
