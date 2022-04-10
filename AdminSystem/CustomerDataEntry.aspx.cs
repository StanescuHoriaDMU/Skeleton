using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 UserId;
    protected void Page_Load(object sender, EventArgs e)
    {
        UserId = Convert.ToInt32(Session["UserId"]);
        if (IsPostBack == false)
        {
            if (UserId != -1)
            {
                DisplayAdress();
            }
        }

    }

    private void DisplayAdress()
    {
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        CustomerList.ThisCustomer.Find(UserId);
        txtUserId.Text = Convert.ToString(CustomerList.ThisCustomer.UserId);
        txtFullName.Text = CustomerList.ThisCustomer.FullName;
        txtEmailAdress.Text = CustomerList.ThisCustomer.EmailAdress;
        txtDateOfBirth.Text = Convert.ToString(CustomerList.ThisCustomer.DateOfBirth);
        txtUsername.Text = CustomerList.ThisCustomer.Username;
        checkboxVerifiedCustomer.Checked = CustomerList.ThisCustomer.VerifiedCustomer;
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
       
        string FullName = txtFullName.Text;
        string EmailAdress = txtEmailAdress.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string Username = txtUsername.Text;
        string Error = "";
        Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
        if(Error == "")
        {
            ACustomer.UserId = UserId;
            ACustomer.FullName = FullName;
            ACustomer.EmailAdress = EmailAdress;
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            ACustomer.Username = Username;
            ACustomer.VerifiedCustomer = checkboxVerifiedCustomer.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if(UserId == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(UserId);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
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