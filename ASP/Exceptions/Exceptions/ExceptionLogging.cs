using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using context = System.Web.HttpContext;

namespace Exceptions
{
    public static class ExceptionLogging
    {
        static string exurl;
        static SqlConnection con;

        private static void getConnection()
        {
            string cstr = ConfigurationManager.ConnectionStrings["Myconn"].ToString();
            con = new SqlConnection(cstr);
            con.Open();
        }

        public static void WriteExceptionToDB(Exception ex)
        {
            getConnection();
            exurl = context.Current.Request.Url.ToString();
            SqlCommand cmd = new SqlCommand("sp_ExceptionLogging", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@exmessage", ex.Message.ToString());
            cmd.Parameters.AddWithValue("@extype", ex.GetType().Name.ToString());
            cmd.Parameters.AddWithValue("@exsrc", ex.StackTrace.ToString());
            cmd.Parameters.AddWithValue("@exurl", exurl);

            cmd.ExecuteNonQuery();
        }
    }
}