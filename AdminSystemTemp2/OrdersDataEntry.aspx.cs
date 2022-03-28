using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using Testing6;

namespace AdminSystemTemp2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            clsOrder order = new clsOrder();
            order.purchaseID = Int32.Parse( txtPurchaseId.Text);
            order.userID= Int32.Parse(txtUserId.Text);
            order.vehicleID= Int32.Parse(txtVehicle.Text);
            order.dispatched= chkDispatched.Checked;
            order.soldDate = DateTime.Parse(txtSoldDate.Text);
            order.userAddress = txtUserAddress.Text;
            Session["Order"] = order;

            Response.Redirect("OrdersViewer.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}