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

public partial class Login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);
    bl_Login objbl_Login = new bl_Login();
    protected void Page_Load(object sender, EventArgs e)
    {

        LinkButton1.Visible = true;
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text.ToString() == "" || txtPassword.Text.ToString() == "")
            Page.RegisterStartupScript("", "<script>alert('Please enter username and password')</script>");
        else
        {
            try
            {
                objbl_Login.UserName = txtUserName.Text;
                objbl_Login.Password = txtPassword.Text;

                DataSet ds = new DataSet();

                ds = objbl_Login.CheckUser();
                if (ds.Tables[0].Rows.Count > 0)
                {


                    if ((ds.Tables[0].Rows[0]["username"].ToString().ToLower() == txtUserName.Text.ToLower()) && (ds.Tables[0].Rows[0]["password"].ToString().ToLower() == txtPassword.Text.ToLower()))
                    {
                        Session["UserName"] = txtUserName.Text;
                        if (ds.Tables[0].Rows[0][2].ToString() == "Writer")
                        {
                            Response.Redirect("~/writer/writerhome.aspx");
                        }
                        else if (ds.Tables[0].Rows[0][2].ToString() == "Admin")
                        {
                            Response.Redirect("~/Admin/adminhome.aspx");

                        }
                        else if (ds.Tables[0].Rows[0][2].ToString() == "Editor")
                        {
                            Response.Redirect("~/editor/editorhome.aspx");

                        }


                    }
                }
                else
                {
                    Page.RegisterStartupScript("", "<script>alert('Invalid username/password')</script>");
                }
            }
            catch (Exception ex) { }
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewScriptWriter.aspx");
    }
}
