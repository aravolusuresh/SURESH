using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bl_script
/// </summary>
public class bl_script
{
	public bl_script()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    string title;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    string writer;

    public string Writer
    {
        get { return writer; }
        set { writer = value; }
    }
    string typeofscript;

    public string Typeofscript
    {
        get { return typeofscript; }
        set { typeofscript = value; }
    }
    static  string description;


    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    string script;


    public string Script
    {
        get { return script; }
        set { script = value; }
    }


    public int insert()
    {
        
        return dl_script.insert(this);
    }

    public System.Data.DataSet getmyscripts()
    {

        return dl_script.getmyscripts(this);
    }

    public int verified()
    {
        throw new NotImplementedException();
    }

    public System.Data.DataSet viewall()
    {
        return dl_script.viewall(this);
    }

    public int accepted()
    {
        return dl_script.accepted(this);
    }

    public int rejected()
    {
        return dl_script.rejected(this);
    }

    public static System.Data.DataSet acceptedscripts()
    {
        return dl_script.acceptedscripts();
    }

    public static System.Data.DataSet rejectedscripts()
    {
        return dl_script.rejectedscripts();
    }
    public System.Data.DataSet Updatesscripts(string title,string desc)
    {
        return dl_script.Updatescripts(title,desc);
    }
}
