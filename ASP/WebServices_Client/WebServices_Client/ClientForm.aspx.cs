using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServices_Client
{
    public partial class ClientForm : System.Web.UI.Page
    {
        ServiceProxy.CalculatorServiceSoapClient client = new ServiceProxy.CalculatorServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnmessage_Click(object sender, EventArgs e)
        {
            
            lblmessage.Text=client.Message(txtstr.Text);
        }

        protected void btnaddnos_Click(object sender, EventArgs e)
        {
            lblmessage.Text = client.add2Nos(int.Parse(txtnum1.Text), int.Parse(txtnum2.Text)).ToString();
        }

        protected void btndisplay_Click(object sender, EventArgs e)
        {
            lblmessage.Text=client.HelloWorld();
        }
    }
}