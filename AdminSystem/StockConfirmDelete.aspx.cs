using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance clsStockList
        clsStockList aStock = new clsStockList();
        //get data from from session object
        aStock = (clsStockList)Session["aStock"];
        //display the Vehicle Id for this entry
        Response.Write(aStock.Vmodel);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStockList
        clsStockList aStock = new clsStockList();
        //capture the Vehicle Id
        aStock.Vmodel = txtVehicleNo.Text;
        //store the Vehicle Id in the session object
        Session["aStock"] = aStock;
        //navigate to viewer page
        Response.Redirect("StockConfirmDelete.aspx");
    }
}