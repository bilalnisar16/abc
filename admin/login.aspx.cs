using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnadditem_Click(object sender, EventArgs e)
    {
        string name = Textbox1.Text;
        string password = Textbox2.Text;
        if(name=="admin" && password=="admin1234")
        {
            Response.Redirect("~/admin/Default.aspx");
        }
        else
        {
            lblmsg.Text = "invalid username password";
            lblmsg.Visible = true;
        }

    }
}