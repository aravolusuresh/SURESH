using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for dl_feedback
/// </summary>
public class dl_feedback
{
   
	public dl_feedback()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    internal static int insert(bl_feedback bl_feedback)
    {
       
        SqlConnection con = SQlCon.Connection();
        SqlCommand cmd = new SqlCommand("feed", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@name", bl_feedback.Name);
        cmd.Parameters.AddWithValue("@feedback", bl_feedback.Feedback);
        cmd.Parameters.AddWithValue("@date", DateTime.Now);
        cmd.Parameters.AddWithValue("@type", 'i');
        con.Open();
        int i = cmd.ExecuteNonQuery();
        con.Close();
        return i;
        
    }

    internal static DataSet getfeedback(bl_feedback bl_feedback)
    {
        SqlConnection con = SQlCon.Connection();
         DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand("feed",con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@type", 'g');
        da.Fill(ds);
        return ds;
    }
}
