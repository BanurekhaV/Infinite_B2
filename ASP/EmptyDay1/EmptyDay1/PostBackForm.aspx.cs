using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmptyDay1
{
    public partial class PostBackForm : System.Web.UI.Page
    {
        int clickscount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtdata.Text = "0";
            }
        }

        protected void btnstate_Click(object sender, EventArgs e)
        {
            /*Step 1
            clickscount = clickscount + 1;
            txtdata.Text = clickscount.ToString();

            Step 2 using ViewState variable
            if(ViewState["clicks"]!=null)
            {
                clickscount = (int)ViewState["clicks"] + 1;
            }
            txtdata.Text = clickscount.ToString();
            ViewState["clicks"] = clickscount; */

            //step 3 without viewstate variable (since each asp control has a view state variable
            clickscount = Convert.ToInt32(txtdata.Text) + 1;
            txtdata.Text = clickscount.ToString();
        }
    }
}