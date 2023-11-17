using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrossPage_PostBack
{
    public partial class Toolbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if(FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(@"C:\Banu\Infinite\B2\" + FileUpload1.FileName);
                lbl1.Text = "File Uploaded :" + FileUpload1.FileName;
            }
        }
    }
}