using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bl_viewwriterprofiles
/// </summary>
public class bl_viewwriterprofiles
{
	public bl_viewwriterprofiles()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public System.Data.DataSet getprofiles()
    {
        return dl_viewwriterprofiles.getprofiles(this);

    }
}
