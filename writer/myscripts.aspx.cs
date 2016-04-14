using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class writer_myscripts : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    bl_script viewscript = new bl_script();

    protected void Page_Load(object sender, EventArgs e)
    {
        viewscript.Writer = Session["UserName"].ToString();
        ds = viewscript.getmyscripts();
        if (ds.Tables[0].Rows.Count > 0)
        {
            myscriptsgrid.DataSource = ds.Tables[0];
            myscriptsgrid.DataBind();
        }
        else
        {
            Page.RegisterStartupScript("Alert", "<script>alert('No Scripts Found.')</script>");
        }
    }
}
