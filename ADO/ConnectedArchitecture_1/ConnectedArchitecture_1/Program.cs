using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedArchitecture_1
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            SelectData();
            Console.Read();
        }

        static void SelectData()
        {
            //get the connection object
            con = GetConnection();
            //issue the command
            //  cmd = new SqlCommand("select * from tblemployee", con); or
            cmd = new SqlCommand("select * from tblemployee");
            cmd.Connection = con;
            dr=cmd.ExecuteReader();
            while(dr.Read())
            {
                // Console.WriteLine(dr[0] + " "+dr[1] +" "+dr[2]+" "+dr[3]+" "+dr[4]);
                Console.WriteLine("Employee Id :" + " " +dr[0]);
                Console.WriteLine("Employee Name :" + " " + dr[1]);
                Console.WriteLine("Employee Gender :" + " " + dr[2]);
                Console.WriteLine("Employee Salary :" + " " + dr[3]);
                Console.WriteLine("Employee Department :" + " " + dr[4]);
                Console.WriteLine("---------------------------");
            }

        }
        static SqlConnection GetConnection()
        {
            //when windows authenticated
            con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;Initial Catalog=InfiniteDB;" +
                "Integrated Security=True");
            con.Open();
            return con;
            //when sql authenticated
           // con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;Initial Catalog=InfiniteDB;"+
           //"user id=sa;password=pwd);
        }
    }
}
