using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class CookieDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnload_Click(object sender, EventArgs e)
        {
            //persistent cookie
            //HttpCookie rc = Request.Cookies["TestCookie"];
            //lblname.Text = rc["t1"];
            //lblmail.Text = rc["t2"];
            lblname.Text = Request.Cookies["d1"].Value.ToString();
            lblmail.Text = Request.Cookies["d2"].Value.ToString();
        }
    }
}