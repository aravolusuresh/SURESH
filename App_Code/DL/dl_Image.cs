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
/// Summary description for dl_Image
/// </summary>
public class dl_Image
{
	public dl_Image()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static DataTable getEditorImage(int eid)
    {
        SqlConnection con = SQlCon.Connection();
        SqlDataAdapter da = new SqlDataAdapter("select eid,image from tbl_scripteditor where eid=" + eid, con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }

    public static DataTable getWritorImage(int wid)
    {
        SqlConnection con = SQlCon.Connection();
        SqlDataAdapter da = new SqlDataAdapter("select wid,image from tbl_scriptwritor where wid=" + wid, con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
}
