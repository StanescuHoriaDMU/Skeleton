using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsStaff AStaff = new clsStaff();
        //capture the staff ID
        AStaff.StaffID = txtStaffNo.Text;
        AStaff.FullName = txtFullName.Text;
        AStaff.EmailAddress = txtEmailAddress.Text;
        AStaff.DOB = txtDOB.Text;
        AStaff.UserName = txtUserName.Text;
        //store the address in the session object
        Session["AStaff"] = AStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");

    }
}