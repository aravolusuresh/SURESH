using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class writer_myprofile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        bl_scriptwritor sw = new bl_scriptwritor();

        sw.UserName = Session["UserName"].ToString();


        DataSet ds = new DataSet();
        ds = sw.getprofile();
        DetailsView1.DataSource = ds.Tables[0];
        DetailsView1.DataBind();


    }
}
