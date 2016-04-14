using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data;
using System.Data.SqlClient;

public partial class editor_accepted : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null)
        {
            Response.Redirect("~/Login.aspx");
        }
        else
        {
            if (!IsPostBack)
            {
                Show();

            }
            
               // Update();
            
        }
       
        
    }
    public void Show()
    {
        DataSet ds = new DataSet();
        ds = bl_script.acceptedscripts();
        viewgrid.DataSource = ds.Tables[0];
        viewgrid.DataBind();
        Literal1.Visible = false;
        txtdesc.Visible = false;
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        Literal1.Visible = true;
        txtdesc.Visible = true;
        //viewgrid.SelectedRow.Cells[4].Text=txtdesc.Text ;
        viewgrid.SelectedRow.Cells[4].Text = Literal1.Text;
         Update();
        //bl_script obj = new bl_script();

        //string uname = Session["UserName"].ToString();
        //con = new SqlConnectionConfigurationManager.ConnectionStrings["mycon"].ConnectionString);
        //cmd = new SqlCommand("update tbl_script set description='" + s + "' where title='" + uname + "'", con);
        //con.Open();
        //cmd.ExecuteNonQuery();
        //viewgrid.EditIndex = -1;
        //Show();
        //con.Close();
        
    }
    protected void viewgrid_SelectedIndexChanged1(object sender, EventArgs e)
    {
        Literal1.Visible = true;
        txtdesc.Visible = true;
        Button1.Visible = true;
        txtdesc.Text = viewgrid.SelectedRow.Cells[4].Text;
        lbltitle.Text = viewgrid.SelectedRow.Cells[1].Text;
        //Update();
    }
    public void Update()
    {
        bl_script obj = new bl_script();
        obj.Title = txtdesc.Text;
        
        System.Data.DataSet ds = new System.Data.DataSet();
        ds = obj.Updatesscripts(lbltitle.Text,txtdesc.Text);
        //ds = bl_script.
        if (ds.Tables[0].Rows.Count > 0)
        {
            viewgrid.DataSource = ds.Tables[0];
            viewgrid.DataBind();
            Literal1.Visible = false;
            txtdesc.Visible = false;
            Button1.Visible = false;
        }
    }
}
