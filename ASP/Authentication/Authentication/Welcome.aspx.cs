using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Authentication
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("application Code Executed using ...");
            Response.Write(System.Security.Principal.WindowsIdentity.GetCurrent().Name + "<br/>");

            Response.Write("Is User Authenticated");
            Response.Write(User.Identity.IsAuthenticated.ToString() + "<br/>");

            Response.Write("Authentication Type, if Authenticated :");
            Response.Write(User.Identity.AuthenticationType + "<br/>");

            Response.Write("User name if Authenticated..");
            Response.Write(User.Identity.Name + "<br/>");


        }
    }
}