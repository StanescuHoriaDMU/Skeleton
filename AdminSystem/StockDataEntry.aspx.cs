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
        clsStockList aStock = new clsStockList();
        if (txtVehicleId.Text.Length == 0)
        {
            aStock.VehicleId = 0;
        }
        else
        {
            aStock.VehicleId = int.Parse(txtVehicleId.Text);
        }
        aStock.YOV = txtYOV.Text;
        aStock.Vmodel = txtVModel.Text;
        aStock.PriceTag = txtPrice.Text;
        aStock.DateAdded = DateTime.Parse(txtDatePostWasAdded.Text);
        String Error = "";
        Error = aStock.Valid(vehicleId, model, YOV, datePostWasAdded, price) ;
        if (Error == "")
        {



        }
        Session["AStaff"] = aStock;
        Response.Redirect("StockViewer.aspx");

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

        clsStockList aStock = new clsStockList();
        Int32 VehicleId;
        Boolean Found = false;
        if (txtVehicleId.Text.Length == 0)
        {
            VehicleId = 0;
        }
        else
        {
            VehicleId = Convert.ToInt32(txtStaffNo.Text);
        }
        VehicleId = Convert.ToInt32(txtVehicleId.Text);
        Found = aStock.Find(VehicleId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtVehicleId.Text = aStock.VehicleId.ToString();
            txtPostWasAdded.Text = aStock.DateAdded.ToString();
            txtPrice.Text = aStock.PriceTag;
            txtModel.Text = aStock.Vmodel;
            
        }
        else
        {
            throw new InvalidOperationException("VehicleId could not be found");
        }

    }