using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Admin_Admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

       
        
    }
    protected void LoginStatus2_LoggedOut(object sender, EventArgs e)
    {

        Session.Abandon();
        Response.Redirect("~/Login.aspx");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Login.aspx");
        Session.Clear();

    }
}
