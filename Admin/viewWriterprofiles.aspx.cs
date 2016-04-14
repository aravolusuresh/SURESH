using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_viewWriterprofiles : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    bl_viewwriterprofiles view = new bl_viewwriterprofiles();
    protected void Page_Load(object sender, EventArgs e)
    {

        ds = view.getprofiles();
        viewprofilesgrid.DataSource = ds.Tables[0];
        viewprofilesgrid.DataBind();
    }

    protected void viewprofilesgrid_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
