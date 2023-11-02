using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Exceptions
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            //{
            //    //try
            {
                string connectstr = ConfigurationManager.ConnectionStrings["Myconn"].ConnectionString;
                string sql = "select * from tblemployee";
                SqlConnection con = new SqlConnection(connectstr);
                SqlCommand cmd = new SqlCommand(sql, con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Emp");
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }
        //catch (Exception ex)
        //{
        //   lblinfo.Text = "Something went Wrong. Contact Admin";
        //}
        // DataSet ds1 = new DataSet();    

        protected void btn1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Hello.aspx");
        }
    }

        //1. Handling Page Error event for respective pages
        //protected void Page_Error(object sender, EventArgs e)
        //{
        //    Exception ex = Server.GetLastError();
        //    Server.ClearError();
        //    // Response.Write(ex);
        //    Server.Transfer("~/Err2.aspx");
        //}
    
}