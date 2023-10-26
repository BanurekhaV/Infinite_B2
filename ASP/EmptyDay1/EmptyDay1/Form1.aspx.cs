using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmptyDay1
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnwish_Click(object sender, EventArgs e)
        {
            txtname.Text = "Hello and Welcome to ASP.Net Web Forms";
        }
    }
}