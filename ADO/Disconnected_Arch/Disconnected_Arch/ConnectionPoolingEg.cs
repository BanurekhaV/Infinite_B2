using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Disconnected_Arch
{
    class ConnectionPoolingEg
    {
       public static string connectstr = "Data Source=Laptop-tjj7d977; initial Catalog=Northwind;" +
                    "trusted_connection=true;";
        static void Main()
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                SqlConnection con = new SqlConnection(connectstr);
                con.Open();
                con.Close();
            }
            stopwatch.Stop();
            Console.WriteLine($"Pooling = true, Time Taken : {stopwatch.ElapsedMilliseconds} ms");
            TransactionEg(connectstr);
            Console.Read();
        }

        public static void TransactionEg(string cstr)
        {
            using (SqlConnection con = new SqlConnection(cstr))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                SqlTransaction transaction;

                //start a transaction
                transaction = con.BeginTransaction("SimpleTran");
                cmd.Connection = con;
                cmd.Transaction = transaction;
                try
                {
                    cmd.CommandText="Insert into Region values(20,'2ndSimpleRegion')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Insert into Region values(16,'NotSimpleRegion')";
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    Console.WriteLine("Comitted Both Transactions..");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Commit Exception Type :{0}", ex.GetType());
                    Console.WriteLine(ex.Message);
                    try
                    {
                        transaction.Rollback();
                    }
                    catch(Exception ex2)
                    {
                        Console.WriteLine("Rollback exception : {0}", ex2.GetType());
                        Console.WriteLine(ex2.Message);
                    }
                }
            }
        }
    }
}
