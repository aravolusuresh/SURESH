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
/// Summary description for dl_scripteditor
/// </summary>
public class dl_scripteditor
{
	public dl_scripteditor()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    internal static int InsertScriptEditor(bl_scripteditor objbl_scripteditor)
    {
        SqlConnection con = SQlCon.Connection();

        SqlCommand cmd = new SqlCommand("sp_scripteditor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@firstname", objbl_scripteditor.FirstName);
        cmd.Parameters.AddWithValue("@lastname", objbl_scripteditor.LastName);
        cmd.Parameters.AddWithValue("@surname", objbl_scripteditor.SurName);
        cmd.Parameters.AddWithValue("@emailid", objbl_scripteditor.EmailId);
        cmd.Parameters.AddWithValue("@phonenumber", objbl_scripteditor.PhoneNumber);
        cmd.Parameters.AddWithValue("@dateofbirth", objbl_scripteditor.DateOfBirth);
        cmd.Parameters.AddWithValue("@gender", objbl_scripteditor.Gender);
        cmd.Parameters.AddWithValue("@qualification", objbl_scripteditor.Qualification);
        cmd.Parameters.AddWithValue("@experience", objbl_scripteditor.Experience);
        cmd.Parameters.AddWithValue("@country", objbl_scripteditor.Country);
        cmd.Parameters.AddWithValue("@state", objbl_scripteditor.State);
        cmd.Parameters.AddWithValue("@city", objbl_scripteditor.City);
        cmd.Parameters.AddWithValue("@username", objbl_scripteditor.UserName);
        cmd.Parameters.AddWithValue("@password", objbl_scripteditor.Password);
        cmd.Parameters.AddWithValue("@usertype", objbl_scripteditor.Usertype);
        cmd.Parameters.AddWithValue("@image", objbl_scripteditor.Image);

        cmd.Parameters.AddWithValue("@type", 'i');

        con.Open();
        int res = cmd.ExecuteNonQuery();
        con.Close();
        return res;

    }

    internal static int AcceptEditor(bl_scripteditor objbl_scripteditor)
    {
        SqlConnection con = SQlCon.Connection();

        SqlCommand cmd = new SqlCommand("sp_scripteditor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@eid", objbl_scripteditor.Eid);
        cmd.Parameters.AddWithValue("@accepted", true);
        cmd.Parameters.AddWithValue("@type", 'a');

        con.Open();
        int res = cmd.ExecuteNonQuery();
        con.Close();
        return res;
    }

    internal static DataSet getUnAccetedEditors()
    {
        SqlConnection con = SQlCon.Connection();

        SqlCommand cmd = new SqlCommand("sp_scripteditor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@type", 'g');
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static int DeAcceptEditor(bl_scripteditor objbl_scripteditor)
    {
        SqlConnection con = SQlCon.Connection();

        SqlCommand cmd = new SqlCommand("sp_scripteditor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@eid", objbl_scripteditor.Eid);
        cmd.Parameters.AddWithValue("@accepted", false);
        cmd.Parameters.AddWithValue("@type", 'd');

        con.Open();
        int res = cmd.ExecuteNonQuery();
        con.Close();
        return res;
    }

    internal static DataSet getAccetedEditors()
    {
        SqlConnection con = SQlCon.Connection();

        SqlCommand cmd = new SqlCommand("sp_scripteditor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@type", 'u');
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static DataSet getScriptEditors()
    {
        SqlConnection con = SQlCon.Connection();

        SqlCommand cmd = new SqlCommand("sp_scripteditor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@type", 'v');
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
}
