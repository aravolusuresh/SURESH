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

/// <summary>
/// Summary description for bl_Login
/// </summary>
public class bl_Login
{
	public bl_Login()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private string _UserName;
    public string UserName
    {
        get { return _UserName; }
        set { _UserName = value; }
    }
    private string _Password;
    public string Password
    {
        get { return _Password; }
        set { _Password = value; }
    }
    private string _UserType;
    public string UserType
    {
        get { return _UserType; }
        set { _UserType = value; }
    }

    public DataSet CheckUser()
    {
        return dl_Login.CheckUser(this);
    }

    //public DataSet NewUser()
    //{
    //    return dl_Login.NewUser(this);
    //}
}
