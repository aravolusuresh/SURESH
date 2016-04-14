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
/// Summary description for bl_country
/// </summary>
public class bl_country
{
	public bl_country()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private string _Country;
    public string Country
    {
        get { return _Country; }
        set { _Country = value; }
    }

    private string _State;
    public string State
    {
        get { return _State; }
        set { _State = value; }
    }
    private string _City;
    public string City
    {
        get { return _City; }
        set { _City = value; }
    }


    public DataSet SelectCounries()
    {
        return dl_country.SelectCounries();
    }

    public DataSet selectStates()
    {
        return dl_country.selectStates(this);
    }

    public DataSet selectcities()
    {
        return dl_country.selectcities(this);
    }
}
