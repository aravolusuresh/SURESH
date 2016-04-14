using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for dl_changepass
/// </summary>
    public class dl_changepass
{
	public dl_changepass()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    internal static int changepassword(changepass changepass)
    {
       
            //throw new NotImplementedException();
            SqlConnection con = SQlCon.Connection();
            SqlCommand cmd = new SqlCommand("changepass", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@current", changepass.Currentpassword);
            cmd.Parameters.AddWithValue("@new", changepass.Newpassword);
            cmd.Parameters.AddWithValue("@confirm", changepass.Conformpassword);
            cmd.Parameters.AddWithValue("@username", changepass.Username);
            cmd.Parameters.AddWithValue("@type", 'p');
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();
            return i;
     
        
        
        
    }
}
