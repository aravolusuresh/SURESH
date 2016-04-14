using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_Viewfeedbacks : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    bl_feedback feed = new bl_feedback();
    protected void Page_Load(object sender, EventArgs e)
    {
        ds = feed.getfeedbacks();
        feedbackgrid.DataSource = ds.Tables[0];
        feedbackgrid.DataBind();

    }
}
