using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class SessionSecond : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnretrieve_Click(object sender, EventArgs e)
        {
            Lblname.Text = Session["name"].ToString();
            Lblmail.Text = Session["mail"].ToString();
        }
    }
}