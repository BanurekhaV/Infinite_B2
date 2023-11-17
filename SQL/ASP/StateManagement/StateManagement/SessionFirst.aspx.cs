using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class SessionFirst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSetSession_Click(object sender, EventArgs e)
        {
            //create seesion state variables
            Session["name"] = txtname.Text;
            Session["mail"] = txtmail.Text;
            Response.Redirect("SessionSecond.aspx");
        }
    }
}