using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Authentication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           // if(Membership.ValidateUser(txtusername.Text,txtpassword.Text))
            if(FormsAuthentication.Authenticate(txtusername.Text,txtpassword.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtusername.Text, false);
            }
            else
            {
                lblmessage.Text = "Invalid User or Password";
            }
        }
    }
}