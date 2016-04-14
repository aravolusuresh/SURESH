using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for dl_search
/// </summary>
public class dl_search
{
	public dl_search()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    internal static DataSet getresults(bl_search bl_search)
    {
        SqlConnection con = SQlCon.Connection();

        SqlCommand cmd = new SqlCommand("sp_search", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@search", bl_search.Search);
        cmd.Parameters.AddWithValue("@type", 's');
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
        
    }
}
