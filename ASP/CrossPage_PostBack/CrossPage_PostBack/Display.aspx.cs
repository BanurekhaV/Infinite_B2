using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrossPage_PostBack
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(PreviousPage !=null && PreviousPage.IsCrossPagePostBack)
            {
                TextBox txtname = (TextBox)PreviousPage.FindControl("txtname");
                lblname.Text = "Welcome " + txtname.Text;
            }
            else
            {
                Response.Redirect("Index.aspx");
            }
        }
    }
}