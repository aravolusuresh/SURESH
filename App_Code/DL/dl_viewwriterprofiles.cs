using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for dl_viewwriterprofiles
/// </summary>
public class dl_viewwriterprofiles
{
    public dl_viewwriterprofiles()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    internal static System.Data.DataSet getprofiles(bl_viewwriterprofiles bl_viewwriterprofiles)
    {
        DataSet ds = new DataSet();
        SqlConnection con = SQlCon.Connection();
        SqlCommand cmd = new SqlCommand("Writor_GetALL", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.CommandType = CommandType.StoredProcedure;
        da.Fill(ds);
        return ds;
    }
}
