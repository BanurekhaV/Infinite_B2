using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validations
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Response.Redirect("Valid.html");
            }
            else
            {
                Response.Write("Validations Failed... Please Re-enter..");
            }
        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Redirect("Valid.html");
            }
            else
            {
                Response.Write("Validations Failed... Please Re-enter..");
            }
        }
    }
}