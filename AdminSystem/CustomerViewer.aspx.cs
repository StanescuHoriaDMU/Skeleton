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
        clsCustomer ACustomer = new clsCustomer();
        ACustomer = (clsCustomer)Session["ACustomer"];
        Response.Write(ACustomer.UserId);
        Response.Write(ACustomer.FullName);
        Response.Write(ACustomer.EmailAdress);
        Response.Write(ACustomer.DateOfBirth);
        Response.Write(ACustomer.Username);
        Response.Write(ACustomer.VerifiedCustomer);


    }
}