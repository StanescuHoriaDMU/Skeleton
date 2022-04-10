using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "UserId";
        lstCustomerList.DataTextField = "FullName";
        lstCustomerList.DataBind();

    }

    protected void addBtn_Click(object sender, EventArgs e)
    {
        Session["UserId"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 UserId;
        if(lstCustomerList.SelectedIndex != -1)
        {
            UserId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["UserId"] = UserId;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 UserId;
        if(lstCustomerList.SelectedIndex != -1)
        {
            UserId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["UserId"] = UserId;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByFullName(txtFilter.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "UserId";
        lstCustomerList.DataTextField = "FullName";
        lstCustomerList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByFullName("");
        txtFilter.Text = "";
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "UserId";
        lstCustomerList.DataTextField = "FullName";
        lstCustomerList.DataBind();
    }
}