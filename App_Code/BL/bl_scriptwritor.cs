﻿using System;
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
/// Summary description for bl_scriptwritor
/// </summary>
public class bl_scriptwritor
{
	public bl_scriptwritor()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private int _Wid;
    public int Wid
    {
        get { return _Wid; }
        set { _Wid = value; }
    }
    private string _FirstName;
    public string FirstName
    {
        get { return _FirstName; }
        set { _FirstName = value; }
    }
    private string _LastName;
    public string LastName
    {
        get { return _LastName; }
        set { _LastName = value; }
    }
    private string _SurName;
    public string SurName
    {
        get { return _SurName; }
        set { _SurName = value; }
    }
    private string _EmailId;
    public string EmailId
    {
        get { return _EmailId; }
        set { _EmailId = value; }
    }
    private string _PhoneNumber;
    public string PhoneNumber
    {
        get { return _PhoneNumber; }
        set { _PhoneNumber = value; }
    }
    private string _Gender;
    public string Gender
    {
        get { return _Gender; }
        set { _Gender = value; }
    }
    private string _DateOfBirth;
    public string DateOfBirth
    {
        get { return _DateOfBirth; }
        set { _DateOfBirth = value; }
    }
    private string _Qualification;
    public string Qualification
    {
        get { return _Qualification; }
        set { _Qualification = value; }
    }
    private int _Experience;
    public int Experience
    {
        get { return _Experience; }
        set { _Experience = value; }
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
    private byte[] _Image;
    public byte[] Image
    {
        get { return _Image; }
        set { _Image = value; }
    }
    private Boolean _Accepted;
    public Boolean Accepted
    {
        get { return _Accepted; }
        set { _Accepted = value; }
    }
   
    public int InsertScriptWritor()
    {
        return dl_scriptwritor.InsertScriptWritor(this);
    }

    public DataSet getUnAccetedWritors()
    {
        return dl_scriptwritor.getUnAccetedWritors();
    }

    public int AcceptWritor()
    {
        return dl_scriptwritor.AcceptWritor(this);
    }
    public int DeAcceptWritor()
    {
        return dl_scriptwritor.DeAcceptWritor(this);
    }

    public DataSet getAccetedWritors()
    {
        return dl_scriptwritor.getAccetedWritors();
    }

    public DataSet getScriptWritors()
    {
        return dl_scriptwritor.getScriptWritors();
    }



    public DataSet getprofile()
    {
        return dl_scriptwritor.getprofile(this);
    }
}
