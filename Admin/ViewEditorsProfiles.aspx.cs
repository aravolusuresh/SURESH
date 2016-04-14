using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Admin_ViewEditorsProfiles : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    bl_vieweditorprofiles vieweditor = new bl_vieweditorprofiles();
    protected void Page_Load(object sender, EventArgs e)
    {
        ds = vieweditor.GetProfiles();
        viewprofilesgrid.DataSource = ds;
        viewprofilesgrid.DataBind();


    }
    protected void viewprofilesgrid_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
