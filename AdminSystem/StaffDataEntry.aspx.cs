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
        clsStaff AStaff = new clsStaff();
        if (txtStaffNo.Text.Length == 0)
        {
            AStaff.StaffID = 0;
        }
        else
        {
            AStaff.StaffID = int.Parse(txtStaffNo.Text);
        }
        AStaff.FullName = txtFullName.Text;
        AStaff.EmailAddress = txtEmailAddress.Text;
        AStaff.UserName = txtUserName.Text;
        AStaff.DOB = DateTime.Parse(txtDOB.Text);
        Session["AStaff"] = AStaff;
        Response.Redirect("StaffViewer.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
      
        clsStaff Astaff = new clsStaff();
        Int32 StaffID;
        Boolean Found = false;
        if (txtStaffNo.Text.Length == 0)
        {
            StaffID = 0;
        }
        else
        {
            StaffID = Convert.ToInt32(txtStaffNo.Text);
        }
        StaffID = Convert.ToInt32(txtStaffNo.Text);
        Found = Astaff.Find(StaffID);
        //if found
        if (Found == true) {
            //display the values of the properties in the form
            txtStaffNo.Text = Astaff.StaffID.ToString();
            txtDOB.Text = Astaff.DOB.ToString();
            txtEmailAddress.Text = Astaff.EmailAddress;
            txtFullName.Text = Astaff.FullName;
            txtUserName.Text = Astaff.UserName;
        }
        else
        {
            throw new InvalidOperationException("StaffID could not be found");
        }
        



    }
}