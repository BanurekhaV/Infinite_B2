using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validations
{
    public partial class CustomForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Label1.Text = "Data Validated successfully, saving..";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label1.Text = "Validation Failed, not saving..";
                Label1.ForeColor = System.Drawing.Color.Red;
            }

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(args.Value=="")
            {
                args.IsValid = false;
            }
            else
            {
                if (Convert.ToInt32(args.Value) > 0 && (Convert.ToInt32(args.Value) % 2 == 0))
                {
                    args.IsValid = true;
                }
                else
                    args.IsValid = false;
            }
        }
    }
}