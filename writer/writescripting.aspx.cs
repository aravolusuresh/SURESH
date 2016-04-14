using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class writer_writescripting : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        Literal1.Visible = false;
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        
        bl_script script = new bl_script();
        script.Title = txttitle.Text;
        script.Writer = Session["UserName"].ToString();
        script.Typeofscript = txttype.Text;
        //script.Description = txtdesc.Text;
        script.Script = txtscript.Text;

        int i = script.insert();
        if (i > 0)
        {
            txttitle.Text = string.Empty;
            txttype.Text = string.Empty;
            txtscript.Text = string.Empty;
            //txtdesc.Text = string.Empty;
            Response.Write("<script>alert('your script created successfully')</script>");
      
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("select title from tbl_script where title='"+txttitle.Text+"'", con);
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Literal1.Visible = true;
            Literal1.Text = "The title is already exists";
        }
        else if (!dr.Read())
        {
            //    Response.Write("already exist");
            Literal1.Visible = true;
            Literal1.Text = "You can proceed now";
        }
        else 
        {
 
        }
        dr.Close();
        con.Close();
    }
}
