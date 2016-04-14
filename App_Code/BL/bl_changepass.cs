using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for changepass
/// </summary>
public class changepass
{
	public changepass()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    string username;

    public string Username
    {
        get { return username; }
        set { username = value; }
    }
    string currentpassword;

    public string Currentpassword
    {
        get { return currentpassword; }
        set { currentpassword = value; }
    }
    string newpassword;

    public string Newpassword
    {
        get { return newpassword; }
        set { newpassword = value; }
    }
    string conformpassword;

    public string Conformpassword
    {
        get { return conformpassword; }
        set { conformpassword = value; }
        //7332
    }

    public int changepassword()
    {

     return dl_changepass.changepassword(this);

    }
}
