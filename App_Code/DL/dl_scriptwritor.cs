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
/// Summary description for bl_scriptwritor
/// </summary>
public class dl_scriptwritor
{
	public dl_scriptwritor()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    internal static int InsertScriptWritor(bl_scriptwritor objbl_scriptwritor)
    {
        SqlConnection con = SQlCon.Connection();

        SqlCommand cmd = new SqlCommand("sp_scriptwritor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@firstname", objbl_scriptwritor.FirstName);
        cmd.Parameters.AddWithValue("@lastname", objbl_scriptwritor.LastName);
        cmd.Parameters.AddWithValue("@surname", objbl_scriptwritor.SurName);
        cmd.Parameters.AddWithValue("@emailid", objbl_scriptwritor.EmailId);
        cmd.Parameters.AddWithValue("@phonenumber", objbl_scriptwritor.PhoneNumber);
        cmd.Parameters.AddWithValue("@dateofbirth", objbl_scriptwritor.DateOfBirth);
        cmd.Parameters.AddWithValue("@gender", objbl_scriptwritor.Gender);
        cmd.Parameters.AddWithValue("@qualification", objbl_scriptwritor.Qualification);
        cmd.Parameters.AddWithValue("@experience", objbl_scriptwritor.Experience);
        cmd.Parameters.AddWithValue("@country", objbl_scriptwritor.Country);
        cmd.Parameters.AddWithValue("@state", objbl_scriptwritor.State);
        cmd.Parameters.AddWithValue("@city", objbl_scriptwritor.City);
        cmd.Parameters.AddWithValue("@username", objbl_scriptwritor.UserName);
        cmd.Parameters.AddWithValue("@password", objbl_scriptwritor.Password);
        cmd.Parameters.AddWithValue("@image", objbl_scriptwritor.Image);

        cmd.Parameters.AddWithValue("@type", 'i');

        con.Open();
        int res = cmd.ExecuteNonQuery();
        con.Close();
        return res;

    }

    internal static DataSet getUnAccetedWritors()
    {
        SqlConnection con = SQlCon.Connection();

        SqlCommand cmd = new SqlCommand("sp_scriptwritor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@type", 'g');
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static int AcceptWritor(bl_scriptwritor objbl_scriptwritor)
    {
        SqlConnection con = SQlCon.Connection();

        SqlCommand cmd = new SqlCommand("sp_scriptwritor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@wid", objbl_scriptwritor.Wid);
        cmd.Parameters.AddWithValue("@accepted", true);
        cmd.Parameters.AddWithValue("@type", 'a');

        con.Open();
        int res = cmd.ExecuteNonQuery();
        con.Close();
        return res;
    }

    internal static int DeAcceptWritor(bl_scriptwritor objbl_scriptwritor)
    {
        SqlConnection con = SQlCon.Connection();

        SqlCommand cmd = new SqlCommand("sp_scriptwritor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@wid", objbl_scriptwritor.Wid);
        cmd.Parameters.AddWithValue("@accepted", false);
        cmd.Parameters.AddWithValue("@type", 'd');

        con.Open();
        int res = cmd.ExecuteNonQuery();
        con.Close();
        return res;
    }

    internal static DataSet getAccetedWritors()
    {
        SqlConnection con = SQlCon.Connection();

        SqlCommand cmd = new SqlCommand("sp_scriptwritor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@type", 'u');
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static DataSet getScriptWritors()
    {
        SqlConnection con = SQlCon.Connection();

        SqlCommand cmd = new SqlCommand("sp_scriptwritor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@type", 'v');
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    internal static DataSet getprofile(bl_scriptwritor bl_scriptwritor)
    {
        SqlConnection con = SQlCon.Connection();
        SqlCommand cmd = new SqlCommand("sp_scriptwritor", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@username", bl_scriptwritor.UserName);
        cmd.Parameters.AddWithValue("@type", 'm');
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;


        
    }
}
