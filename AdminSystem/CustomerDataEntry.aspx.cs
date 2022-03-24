using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
       
        string UserId = txtUserId.Text;
        string FullName = txtFullName.Text;
        string EmailAdress = txtEmailAdress.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string Username = txtUsername.Text;
        string Error = "";
        Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
        if(Error == "")
        {
            ACustomer.FullName = txtFullName.Text;
            ACustomer.EmailAdress = txtEmailAdress.Text;
            ACustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            ACustomer.Username = txtUsername.Text;
            Boolean VerifiedCustomer = checkboxVerifiedCustomer.Checked;
            Session["ACustomer"] = ACustomer;
            Response.Redirect("CustomerViewer.aspx");
        }else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        int UserId;
        Boolean Found = false;
        if (txtUserId.Text.Length == 0)
        {
            UserId = 0;
        }
        else
        {
            UserId = Convert.ToInt32(txtUserId.Text);
        }
        Found = ACustomer.Find(UserId);
        if(Found == true)
        {
            txtUserId.Text = Convert.ToString(ACustomer.UserId);
            txtFullName.Text = ACustomer.FullName;
            txtEmailAdress.Text = ACustomer.EmailAdress;
            txtDateOfBirth.Text = Convert.ToString(ACustomer.DateOfBirth);
            txtUsername.Text = ACustomer.Username;
            checkboxVerifiedCustomer.Checked = ACustomer.VerifiedCustomer;
        }
        else
        {
            throw new InvalidOperationException("UserId could not be found");
        }
    }
}