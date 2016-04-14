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

public partial class FeedBack : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnfeedback_Click(object sender, EventArgs e)
    {
        if (txtname.Text == "")
             Page.RegisterStartupScript("ss", "<script> alert('Enter ur Name') </script>");
        else if (txtfeedback.Text == "")
             Page.RegisterStartupScript("ss", "<script> alert ('Write ur FeedBack') </script>");
            
        
        else
        {

            bl_feedback feedbac = new bl_feedback();
            feedbac.Name = txtname.Text;
            feedbac.Feedback = txtfeedback.Text;
            int i = feedbac.insert();

            if (i > 0)
            {
                Response.Write("<script type=text/javascript>alert('Thank you for giving feedback')</script>");
                txtname.Text = string.Empty;
                txtfeedback.Text = string.Empty;
            }
            else
            {
                Response.Write("<script type=text/javascript>alert('feedback not posted')</script>");
            }
        }

    }
}
