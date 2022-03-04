using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the data from the session object
        AStaff = (clsStaff) Session["AStaff"];
        //display the id number for this entry
        Response.Write(AStaff.StaffID);
        Response.Write(AStaff.FullName);
        Response.Write(AStaff.EmailAddress);
        Response.Write(AStaff.DOB);
        Response.Write(AStaff.UserName);
    }
}