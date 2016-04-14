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

public partial class NewScriptWriter : System.Web.UI.Page
{
    //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);

    DataSet ds;

    bl_scriptwritor objbl_scriptwritor = new bl_scriptwritor();
    bl_scripteditor objbl_scripteditor = new bl_scripteditor();

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem.Text == "Editor")
        {
            InsertScriptEditor();
        }
        if (RadioButtonList1.SelectedItem.Text == "Writer")
        {

            InsertScriptWritor();
        }

    }

    private void InsertScriptEditor()
    {
        objbl_scripteditor.FirstName = txtFirstName.Text;
        objbl_scripteditor.LastName = txtLastName.Text;
        objbl_scripteditor.SurName = txtSurName.Text;
        objbl_scripteditor.EmailId = txtEmailId.Text;
        objbl_scripteditor.PhoneNumber = txtPhoneNumber.Text;
        objbl_scripteditor.DateOfBirth = GMDatePicker1.Date.ToShortDateString();
        objbl_scripteditor.Gender = drpgender.Text;
        objbl_scripteditor.Qualification = txtQualification.Text;
        objbl_scripteditor.Experience = Convert.ToInt32(txtExperience.Text);
        objbl_scripteditor.Country = ddlCountry.SelectedValue;
        objbl_scripteditor.State = ddlState.SelectedValue;
        objbl_scripteditor.City = txtcity.Text;
        objbl_scripteditor.UserName = txtUserName.Text;
        objbl_scripteditor.Password = txtPassword.Text;
        objbl_scripteditor.Usertype = RadioButtonList1.Text;
        if (fuImage.HasFile)
        {
            int len = fuImage.PostedFile.ContentLength;
            byte[] imagearr = new byte[len];
            HttpPostedFile file = fuImage.PostedFile;
            file.InputStream.Read(imagearr, 0, len);
            objbl_scripteditor.Image = imagearr;
        }
        int res = objbl_scripteditor.InsertScriptEditor();
        if (res > 0)
        {

            Page.RegisterStartupScript("", "<script>alert('Inserterd Sucessfully')</script>");
            Clear_Fileds();
        }
        else
        {
            Page.RegisterStartupScript("", "<script>alert('Not Inserterd')</script>");
        }
    }

    private void InsertScriptWritor()
    {
        objbl_scriptwritor.FirstName = txtFirstName.Text;
        objbl_scriptwritor.LastName = txtLastName.Text;
        objbl_scriptwritor.SurName = txtSurName.Text;
        objbl_scriptwritor.EmailId = txtEmailId.Text;
        objbl_scriptwritor.PhoneNumber = txtPhoneNumber.Text;
        objbl_scriptwritor.DateOfBirth = GMDatePicker1.Date.ToShortDateString();
        objbl_scriptwritor.Gender = drpgender.Text;
        objbl_scriptwritor.Qualification = txtQualification.Text;
        objbl_scriptwritor.Experience = Convert.ToInt32(txtExperience.Text);
        objbl_scriptwritor.Country = ddlCountry.SelectedValue;
        objbl_scriptwritor.State = ddlState.SelectedValue;
        objbl_scriptwritor.City = txtcity.Text;
        objbl_scriptwritor.UserName = txtUserName.Text;
        objbl_scriptwritor.Password = txtPassword.Text;
        if (fuImage.HasFile)
        {
            int len = fuImage.PostedFile.ContentLength;
            byte[] imagearr = new byte[len];
            HttpPostedFile file = fuImage.PostedFile;
            file.InputStream.Read(imagearr, 0, len);
            objbl_scriptwritor.Image = imagearr;

        }
        int res = objbl_scriptwritor.InsertScriptWritor();
        if (res > 0)
        {
            Page.RegisterStartupScript("", "<script>alert('Inserterd Sucessfully')</script>");
            Clear_Fileds();
        }
        else
        {
            Page.RegisterStartupScript("", "<script>alert('Not Inserterd')</script>");
        }
    }

    private void Clear_Fileds()
    {
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtSurName.Text = "";
        txtEmailId.Text = "";
        txtPhoneNumber.Text = "";
        drpgender.SelectedIndex = 0;
        txtQualification.Text = "";
        txtExperience.Text = "";
        ddlCountry.SelectedIndex = 0;
        ddlState.SelectedIndex = 0;
        txtcity.Text = "";
        txtUserName.Text = "";
        txtPassword.Text = "";
        GMDatePicker1.Reset();
    }

}
