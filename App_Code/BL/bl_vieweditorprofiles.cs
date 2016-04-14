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
/// Summary description for bl_vieweditorprofiles
/// </summary>
public class bl_vieweditorprofiles
{
    dl_vieweditorprofiles vieweditor = new dl_vieweditorprofiles();
	public bl_vieweditorprofiles()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataSet GetProfiles()
    {
        return vieweditor.GetProfiles(this);
    }

    
}
