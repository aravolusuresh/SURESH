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
/// Summary description for dl_country
/// </summary>
public class dl_country
{
	public dl_country()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    internal static DataSet SelectCounries()
    {
        SqlConnection con = SQlCon.Connection();

        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand("sp_country", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@type", 'c');
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(ds);
        return ds;
    }

    internal static DataSet selectStates(bl_country objbl_country)
    {
        SqlConnection con = SQlCon.Connection();

        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand("sp_country", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@country", objbl_country.Country);
        cmd.Parameters.AddWithValue("@type", 's');
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(ds);
        return ds;
    }



    internal static DataSet selectcities(bl_country objbl_country)
    {
        SqlConnection con = SQlCon.Connection();

        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand("sp_country", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@state", objbl_country.State);
        cmd.Parameters.AddWithValue("@type", 'i');
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        da.Fill(ds);
        return ds;
    }
}
