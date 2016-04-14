using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class editor_rejected : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        ds = bl_script.rejectedscripts();

        viewgrid.DataSource = ds.Tables[0];
        viewgrid.DataBind();
    }
}
