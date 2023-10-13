using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedArchitecture_1
{
    class Region
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }

        public void GetRegion()
        {
            Console.WriteLine("Enter Region ID:");
            RegionID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Region Description :");
            RegionDescription = Console.ReadLine();
            DataAccess.InsertRegion(RegionID,RegionDescription);
        }

        public void ShowRegionCount()
        {
            DataAccess.GetScalarData();
        }

        public void ShowAllRegions()
        {
            DataAccess.DisplayRegion();
        }
    }

    class DataAccess
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlConnection GetConnectionNorthWind()
        {
            //when windows authenticated
            con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;Initial Catalog=NorthWind;" +
                "Integrated Security=True");
            con.Open();
            return con;            
        }

        public static void InsertRegion(int rid, string rdesc)
        {
            try
            {
                con = GetConnectionNorthWind();
                cmd = new SqlCommand("Insert into Region values(@rid,@rname)", con);
                cmd.Parameters.AddWithValue("@rid", rid);
                cmd.Parameters.AddWithValue("@rname", rdesc);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    Console.WriteLine("Inserted a Region");
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }
        public static void DisplayRegion()
        {
            try
            {
                con = GetConnectionNorthWind();
                cmd = new SqlCommand("Select * from Region", con);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine(dr["RegionID"] + " " +dr["RegionDescription"]);
                }

            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static void GetScalarData()
        {
            con = GetConnectionNorthWind();
            cmd = new SqlCommand("Select count(RegionID) from Region", con);
            //   int regioncount =(int) cmd.ExecuteScalar(); or
            int regioncount = Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("No Of Available Regions :{0}", regioncount);
        }
    }
    class Program2
    {
        static void Main()
        {
            Region r = new Region();
          //  r.GetRegion();
            r.ShowRegionCount();
            r.ShowAllRegions();
            Console.Read();
        }
    }
}
