using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bl_feedback
/// </summary>
public class bl_feedback
{
	public bl_feedback()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    string feedback;

    public string Feedback
    {
        get { return feedback; }
        set { feedback = value; }
    }






    public int insert()
    {
        return dl_feedback.insert(this);
    }

    public System.Data.DataSet getfeedbacks()
    {
        return dl_feedback.getfeedback(this);
    }
}
