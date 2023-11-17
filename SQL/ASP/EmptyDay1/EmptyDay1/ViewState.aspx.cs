using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmptyDay1
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnstore_Click(object sender, EventArgs e)
        {
            ViewState["name"] = txtname.Text;
            ViewState["mail"] = txtmail.Text;
            txtname.Text = " ";
            txtmail.Text = string.Empty;
        }

        protected void Btnload_Click(object sender, EventArgs e)
        {
            string a = ViewState["name"].ToString();
            string b = ViewState["mail"].ToString();
            Lbldata.Text = "Your Name is : " + a + " " + "and your Email is :" + b;
        }
    }
}