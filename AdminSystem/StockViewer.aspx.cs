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
        //creating a new instance of the class
        clsStockList aStock = new clsStockList();
        //get data from session object
        aStock = (clsStockList)Session["aStock"];
        //display vehicle id on the page 
        Response.Write(aStock.Vmodel);
    }

}