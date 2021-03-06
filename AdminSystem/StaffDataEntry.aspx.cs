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
        string StaffID = txtStaffNo.Text;
        string FullName = txtFullName.Text;
        string UserName = txtUserName.Text;
        string EmailAddress = txtEmailAddress.Text;
        string DOB = txtDOB.Text;

        string Error = "";

        Error = AStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
        if (Error == "")
        {
            AStaff.StaffID = Convert.ToInt32(StaffID);
            AStaff.FullName = FullName;
            AStaff.UserName = UserName;
            AStaff.EmailAddress = EmailAddress;
            AStaff.DOB = Convert.ToDateTime(DOB);
            clsStaffCollection StaffList = new clsStaffCollection();
            StaffList.ThisStaff = AStaff;
            StaffList.Add();
            Response.Redirect("StaffList.aspx");
        }
        if (StaffID == "-1")
        {
          //  StaffList.ThisStaff = AStaff;
          //  StaffList.Add();
        }
        else
        {
            lblError.Text = Error;
        }
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

    public partial class AStaff : System.Web.UI.Page
    {
        Int32 StaffID;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            StaffID = Convert.ToInt32(Session["StaffID"]);
            if (IsPostBack == false)
            {
                if (StaffID != -1)
                {
                   /// DisplayStaff();
                }
            }
        }

    }

    void DisplayStaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
       // StaffBook.ThisStaff.Find(StaffID);
        txtStaffNo.Text = StaffBook.ThisStaff.StaffID.ToString();
        txtDOB.Text = StaffBook.ThisStaff.DOB.ToString();
        txtEmailAddress.Text = StaffBook.ThisStaff.EmailAddress;
        txtFullName.Text = StaffBook.ThisStaff.FullName;
        txtUserName.Text = StaffBook.ThisStaff.UserName;
    }

}