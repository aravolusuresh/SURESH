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
/// Summary description for dl_Login
/// </summary>
public class dl_Login
{
	public dl_Login()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    internal static DataSet CheckUser(bl_Login objbl_Login)
    {
        SqlConnection con = SQlCon.Connection();

        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand("sp_Login", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@username", objbl_Login.UserName);
        cmd.Parameters.AddWithValue("@password", objbl_Login.Password);
        cmd.Parameters.AddWithValue("@type", 'c');
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(ds);
        return ds;
    }

    //internal static DataSet NewUser(bl_Login bl_Login)
    //{
    //    SqlConnection con = SQlCon.Connection();

    //    DataSet ds = new DataSet();
    //    SqlCommand cmd = new SqlCommand("select username from tbl_Login", con);
    //   // cmd.Parameters.AddWithValue("@username", objbl_Login.UserName);

    //    SqlDataAdapter da = new SqlDataAdapter(cmd);

    //    da.Fill(ds);
    //    return ds;
    //}
}
