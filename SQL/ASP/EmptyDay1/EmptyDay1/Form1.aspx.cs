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
            Response.Write("Page Load" + "<br/>");
        }

        protected void Btnwish_Click(object sender, EventArgs e)
        {
            txtname.Text = "Hello and Welcome to ASP.Net Web Forms";
        }

        protected void Page_Render(object sender, EventArgs e)
        {
            Response.Write("Render" + "<br/>");
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Init Complete" + "<br/>");
        }
        protected void Page_PreLoad(object sender,EventArgs e)
        {
            Response.Write("Page Pre Load" + "<br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Init " + "<br/>");
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Pre Init" + "<br/>");
        }
        protected void Page_Pre_Render(object sender, EventArgs e)
        {
            Response.Write("Pre Render" + "<br/>");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
           // Response.Write("Unload" + "<br/>");
        }
    }
}