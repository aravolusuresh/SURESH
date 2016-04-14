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
using System.Configuration;

/// <summary>
/// Summary description for SQlCon
/// </summary>
public class SQlCon
{
	public SQlCon()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    internal static System.Data.SqlClient.SqlConnection Connection()
    {
        string str = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        SqlConnection con = new SqlConnection(str);
        return con;
    }
}
