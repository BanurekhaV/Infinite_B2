using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmptyDay1
{
    public partial class HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnstore_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = txtname.Text;
            HiddenField2.Value = txtmail.Text;
            txtname.Text = string.Empty;
            txtmail.Text = string.Empty;
        }

        protected void Btnload_Click(object sender, EventArgs e)
        {
            Lbldata.Text = "Name is :" + HiddenField1.Value + " " + "and Email is :" + HiddenField2.Value;
        }
    }
}