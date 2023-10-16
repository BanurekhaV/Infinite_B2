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
            // Insertdata();
            // DeleteData();
            // SelectData();
            //StoredProc_withParameter();
            StoredProc_WithOutput();
            Console.Read();
        }

        public static void StoredProc_withParameter()
        {
            con = GetConnection();
            Console.WriteLine("Enter Employee Id :");
            int eid = int.Parse(Console.ReadLine());
            cmd = new SqlCommand("getSalary @eid", con); //name of the procedure
            // cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eid", eid);
            dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine($"Employee Name : {dr[0]} and the Salary is {dr[1]} ");
            }
        }

        public static void StoredProc_WithOutput()
        {
            con = GetConnection();
            Console.WriteLine("Enter Employee Name :");
            string ename = Console.ReadLine();
            cmd = new SqlCommand();
            cmd.CommandText = "getEmpSalary";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            //we will use SqlParameter class for input and output parameters
            SqlParameter param1 = new SqlParameter
            {
                ParameterName = "@ename",
                SqlDbType=SqlDbType.NVarChar,
                Value=ename,
                Direction=ParameterDirection.Input
            };

            cmd.Parameters.Add(param1);

            SqlParameter outparam = new SqlParameter
            {
                ParameterName = "@sal",
                SqlDbType = SqlDbType.Float,
                Direction = ParameterDirection.Output
            };           

            cmd.Parameters.Add(outparam);

            cmd.ExecuteScalar();
           Console.WriteLine("Salary of Employee : {0} is : {1}",ename, outparam.Value);
            
        }
        static void DeleteData()
        {
            con = GetConnection();
            Console.WriteLine("Enter the Employee Id to be deleted :");
            int eid = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("select * from tblemployee where eid=@eid");
            cmd1.Connection = con;
            cmd1.Parameters.AddWithValue("@eid", eid);
            SqlDataReader dr1=cmd1.ExecuteReader();

            while(dr1.Read())
            {
                for(int i=0; i<dr1.FieldCount;i++)
                {
                    Console.WriteLine(dr1[i]);
                }
            }
            con.Close();
            Console.WriteLine("Are you sure to delete this Record Y/N");
            string answer = Console.ReadLine();
            if(answer=="Y" ||answer=="y")
            {
                cmd = new SqlCommand("delete from tblemployee where eid=@eid", con);
                cmd.Parameters.AddWithValue("@eid", eid);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if(res>0)
                {
                    Console.WriteLine("Record Deleted Successfully");
                }
                else
                    Console.WriteLine("Some Problem... Contact DB Admin");
            }
        }
        static void Insertdata()
        {
            con = GetConnection();
            //do not hard code the values
            //cmd = new SqlCommand("insert into tblemployee " +
            //    "values(113,'Zainab','Female',6950,1)",con);
            try
            {
                int eid, edid;
                string ename, egender;
                float esalary;
                Console.WriteLine("Please Enter EmpId,EmpName,Gender,Salary and Deptid :");
                eid = Convert.ToInt32(Console.ReadLine());
                ename = Console.ReadLine();
                egender = Console.ReadLine();
                esalary = Convert.ToSingle(Console.ReadLine());
                edid = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("insert into tblemployee values(@id,@nm,@gen,@sal,@did)", con);
                cmd.Parameters.AddWithValue("@id", eid);
                cmd.Parameters.AddWithValue("@nm", ename);
                cmd.Parameters.AddWithValue("@gen", egender);
                cmd.Parameters.AddWithValue("@sal", esalary);
                cmd.Parameters.AddWithValue("@did", edid);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Record Inserted");
                else
                    Console.WriteLine("Not Inserted..");
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
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
                "Integrated Security=True" );
            con.Open();
            return con;

            //when sql authenticated
           // con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;Initial Catalog=InfiniteDB;"+
           //"user id=sa;password=pwd);
        }
    }
}
