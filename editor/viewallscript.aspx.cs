using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class editor_viewallscript : System.Web.UI.Page
{
    bl_script script = new bl_script();
    DataSet ds = new DataSet();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ds = script.viewall();
            viewgrid.DataSource = ds.Tables[0];
            viewgrid.DataBind();
        }
    }
    protected void btnaccept_Click(object sender, EventArgs e)
    {

        for (int i = 0; i < viewgrid.Rows.Count; i++)
        {
            GridViewRow row = viewgrid.Rows[i];
            bool isChecked = ((CheckBox)row.FindControl("chkSelect")).Checked;
            //foreach(GridViewRow gr in viewgrid.Rows)
            //{
            if (((CheckBox)row.Cells[0].FindControl("chkSelect")).Checked == true)
            {
                script.Title = viewgrid.Rows[i].Cells[1].Text;
                int k = script.accepted();
                if (k > 0)
                {
                    ds = script.viewall();
                    viewgrid.DataSource = ds.Tables[0];
                    viewgrid.DataBind();
                }
                else
                {

                }



            }

            //}
            //if (isChecked)
            //{
            //    // Column 1 is the  titlename column



            //}
        }

    }
    protected void btnreject_Click(object sender, EventArgs e)
    {



        for (int i = 0; i < viewgrid.Rows.Count; i++)
        {
            GridViewRow row = viewgrid.Rows[i];
            bool isChecked = ((CheckBox)row.FindControl("chkSelect")).Checked;

            //foreach (GridViewRow gr in viewgrid.Rows)
            //{
                if (((CheckBox)row.Cells[0].FindControl("chkSelect")).Checked == true)
                {
                    script.Title = viewgrid.Rows[i].Cells[1].Text;
                    int k = script.rejected();
                    if (k > 0)
                    {
                        ds = script.viewall();
                        viewgrid.DataSource = ds.Tables[0];
                        viewgrid.DataBind();
                    }
                   
                }

            //}
        }
    }
}


