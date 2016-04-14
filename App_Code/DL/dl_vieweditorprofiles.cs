using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
/// Summary description for dl_vieweditorprofiles
/// </summary>
public class dl_vieweditorprofiles
{
	public dl_vieweditorprofiles()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    internal DataSet GetProfiles(bl_vieweditorprofiles bl_vieweditorprofiles)
    {
        DataSet ds = new DataSet();
        SqlConnection con = SQlCon.Connection();
        SqlCommand cmd = new SqlCommand("Editor_GetALL", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.CommandType = CommandType.StoredProcedure;
        da.Fill(ds);
        return ds;
    }
}
