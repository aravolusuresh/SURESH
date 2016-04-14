using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for dl_script
/// </summary>
public class dl_script
{
    
	public dl_script()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    internal static int insert(bl_script bl_script)
    {
        string stat = "n";
        SqlConnection con = SQlCon.Connection();
        SqlCommand cmd = new SqlCommand("sp_script", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@title", bl_script.Title);
        cmd.Parameters.AddWithValue("@writer", bl_script.Writer);
        cmd.Parameters.AddWithValue("@typeofscript", bl_script.Typeofscript);
       // cmd.Parameters.AddWithValue("@description", bl_script.Description);
        cmd.Parameters.AddWithValue("@script", bl_script.Script);
        cmd.Parameters.AddWithValue("@status",stat);
        cmd.Parameters.AddWithValue("@type",'i');
        con.Open();
        int i=cmd.ExecuteNonQuery();
        con.Close();
        return i;
        
    }

    internal static DataSet getmyscripts(bl_script bl_script)
    {
      
        DataSet ds = new DataSet();
        SqlConnection con = SQlCon.Connection();
        SqlCommand cmd = new SqlCommand("sp_script", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@writer",bl_script.Writer);
        cmd.Parameters.AddWithValue("@type", 'g');
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        return ds;
    }

    internal static DataSet viewall(bl_script bl_script)
    {
        DataSet ds = new DataSet();
        SqlConnection con = SQlCon.Connection();
        SqlCommand cmd = new SqlCommand("sp_script", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@type", 'v');
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        return ds;



    }



    internal static int accepted(bl_script bl_script)
    {
        SqlConnection con = SQlCon.Connection();
        SqlCommand cmd = new SqlCommand("sp_script", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@title", bl_script.Title);
        cmd.Parameters.AddWithValue("@type", 'a');
        con.Open();
        int i = cmd.ExecuteNonQuery();
        con.Close();
        return i;
      
    }

    internal static int rejected(bl_script bl_script)
    {
        SqlConnection con = SQlCon.Connection();
        SqlCommand cmd = new SqlCommand("sp_script", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@title", bl_script.Title);
        cmd.Parameters.AddWithValue("@type", 'r');
        con.Open();
        int i = cmd.ExecuteNonQuery();
        con.Close();
        return i;
        
    }

    internal static DataSet acceptedscripts()
    {
        DataSet ds = new DataSet();
        SqlConnection con = SQlCon.Connection();
        SqlCommand cmd = new SqlCommand("sp_script", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@type", 'B');
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        return ds;
    }
    internal static DataSet Updatescripts(string title, string description)
    {
        DataSet ds = new DataSet();
        SqlConnection con = SQlCon.Connection();
        SqlCommand cmd = new SqlCommand("sp_script", con);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@title", title);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.Parameters.AddWithValue("@type", 'u');
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        return ds;
    }

    internal static DataSet rejectedscripts()
    {

        DataSet ds = new DataSet();
        SqlConnection con = SQlCon.Connection();
        SqlCommand cmd = new SqlCommand("sp_script", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@type", 'd');
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        return ds;
    }
}
