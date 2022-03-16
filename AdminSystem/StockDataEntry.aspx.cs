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
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //A new instance of clsStock
        clsStockList aStock = new clsStockList();
        //capture the vehicle id 
        aStock.Vmodel = txtVehicleId.Text;
        //store the vehicle id in the session object
        Session["aStock"] = aStock;
        //navigate to the viewer page 
        Response.Redirect("StockViewer.aspx");
    }
}