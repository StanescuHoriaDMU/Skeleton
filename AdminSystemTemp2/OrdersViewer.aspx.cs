using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using Testing6;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder order=new clsOrder();
        order = (clsOrder)Session["Order"];
        //Response.Write(order.purchaseID);
        //Response.Write(order.userID);
        //Response.Write(order.vehicleID);
        Response.Write(order.userAddress);
        Response.Write(order.dispatched);
    }
}