using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Exceptions
{
    public partial class DatabaseLogging : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/data.xml"));
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                ExceptionLogging.WriteExceptionToDB(ex);
                Label1.Text = "Some Error Occured, please try after sometime";
            }
        }
    }
}