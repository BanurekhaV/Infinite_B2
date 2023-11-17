using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Caching
{
    public partial class DataForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetProductByName("All");
            }
            else
            {
                Response.Cache.SetExpires(DateTime.Now.AddSeconds(30));//duration
                Response.Cache.VaryByParams["None"] = true;  //vary byparam
                Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate); //location
            }
            lblinfo.Text = "This Page is being Cached  :" + DateTime.Now.ToString();
        }

        protected void Dplist1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductByName(Dplist1.SelectedValue);
        }

        private void GetProductByName(string productname)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;" +
               "Initial Catalog=InfiniteDB;Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("spGetProductByname", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlparam = new SqlParameter();
            sqlparam.ParameterName = "@productname";
            sqlparam.Value = productname;
            da.SelectCommand.Parameters.Add(sqlparam);

            //to display data
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}