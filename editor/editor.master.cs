using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class editor_editor : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LoginStatus2_LoggingOut(object sender, LoginCancelEventArgs e)
    {
        Response.Redirect("~/login.aspx");
    }
}
