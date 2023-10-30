using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching
{
    public partial class Navigation_Eg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("DataForm.aspx");
        }

        protected void btnRedirect1_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.amazon.in");
        }

        protected void btnTransfer_Click(object sender, EventArgs e)
        {
            Server.Transfer("DataForm.aspx");
        }

        protected void btnTransfer2_Click(object sender, EventArgs e)
        {
            Server.Transfer("https://www.amazon.in");
        }
    }
}