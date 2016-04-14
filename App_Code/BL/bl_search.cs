using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bl_search
/// </summary>
public class bl_search
{
	public bl_search()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    string search;

    public string Search
    {
        get { return search; }
        set { search = value; }
    }

    public System.Data.DataSet getresults()
    {
        dl_search dlsearch = new dl_search();
        return dl_search.getresults(this);
    }
}
