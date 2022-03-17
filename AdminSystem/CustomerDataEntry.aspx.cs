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
        if(txtUserId.Text.Length == 0)
        {
            ACustomer.UserId = 0;
        }
        else
        {
            ACustomer.UserId = int.Parse(txtUserId.Text);
        }
        ACustomer.FullName = txtFullName.Text;
        ACustomer.EmailAdress = txtEmailAdress.Text;
        ACustomer.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text);
        ACustomer.Username = txtUsername.Text;
        ACustomer.VerifiedCustomer = checkboxVerifiedCustomer.Checked;
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
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