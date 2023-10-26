using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class CookieSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnredirect_Click(object sender, EventArgs e)
        {
            //persistent cookie
            HttpCookie hc = new HttpCookie("TestCookie");
            hc["t1"] = txtname.Text;
            hc["t2"] = txtmail.Text;
            Response.Cookies.Add(hc);
            hc.Expires = DateTime.Now.AddMinutes(10); // setting the expiry time for the cookie
            Response.Redirect("CookieDestination.aspx");
        }
    }
}