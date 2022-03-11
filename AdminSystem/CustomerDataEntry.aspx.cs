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
        ACustomer.UserId = int.Parse(txtUserId.Text);
        ACustomer.FullName = txtFullName.Text;
        ACustomer.EmailAdress = txtEmailAdress.Text;
        ACustomer.DateOfBirth = DateTime.Parse(txtDateOfBirth.Text);
        ACustomer.Username = txtUsername.Text;
        ACustomer.VerifiedCustomer = checkboxVerifiedCustomer.Checked;
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }
}