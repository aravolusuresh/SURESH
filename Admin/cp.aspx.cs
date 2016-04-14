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
using System.Data.SqlClient;

public partial class Admin_cp : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            Label1.Text = Session["username"].ToString();
        }
        TextBox1.Text = Session["username"].ToString();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string q = "update tbl_Login set password='" + TextBox2.Text + "' where username='" + Label1.Text + "'";
        con.Open();
        SqlCommand cmd = new SqlCommand(q, con);

        cmd.ExecuteNonQuery();
        //Label6.Text = label5.Text";
        Page.RegisterStartupScript("ss", "<script> alert('Password Changed')</script>");

        con.Close();
       // Label2.Text = "Password changed";

    }
}
