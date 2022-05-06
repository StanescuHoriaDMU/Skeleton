using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    int VehicleId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be processed
        VehicleId = Convert.ToInt32(Session["VehicleId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (VehicleId != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }

    private void DisplayStock()
    {
        //create a new instance of the stock collection
        clsStockCollection StockList = new clsStockCollection();
        //find the record to update
        StockList.ThisStock.Find(VehicleId);
        //display the data for this record
        VehicleId.Text = StockList.ThisStock.VehicleId.ToString();
        txtVehicleModel.Text = StockList.ThisStock.VehicleModel;
        txtDatePostWasAdded.Text = StockList.ThisStock.DatePostWasAdded;
        txtQuantity.Text = StockList.ThisStock.Quantity.ToString();
        txtReleaseDate.Text = StockList.ThisStock.InitialReleaseDate.ToString();
        chkIsSold.Checked = StockList.ThisStock.Sold;
        throw new NotImplementedException();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStockList AStock = new clsStockList();

        //capture the vehicle id
        string VehicleId = txtVehicleId.Text;

        //capture the vehicle model
        string VehicleModel = txtVehicleModel.Text;

        //capture the vehicle 
        string DatePostWasAdded = txtDatePostWasAdded.Text;

        //capture the vehicle price
        string PriceTag = txtPrice.Text;

        //capture the shoe release date
        string Sold = txtSold.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AStock.Valid(VehicleId, DatePostWasAdded, PriceTag, Sold, YOV);

        if (Error == "")
        {
            //capture the vehicle id
            AStock.VehicleId = Convert.ToInt32(txtVehicleId.Text);

            //capture the vehicle model description
            AStock.Vmodel = txtVModel.Text;

            //capture the price 
            AStock.PriceTag = txtPrice.Text;

            AStock.YOV = Convert.ToInt32(txtYearOfVehicle.Text);

            AStock.YOV = Convert.ToDateTime(txtReleaseDate.Text);

            AStock.Sold = Convert.ToBoolean(chkIsSold.Checked);

            //create a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i.e. ShoeID = -1 then add the data
            if (Convert.ToInt32(txtVehicleId.Text) == -1)
            {
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //add the new record
                StockList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(Convert.ToInt32(txtVehicleId.Text));
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //update the record
                StockList.Update();
            }


            //redirect back to the listpage
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of clsStock
        clsStockList AStock = new clsStockList();
        //variable to store the primary key
        Int32 VehicleId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        VehicleId = Convert.ToInt32(VehicleId.Text);
        //find the record
        Found = AStock.Find(VehicleId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtVehicleId.Text = AStock.VehicleId;
            txtDatePostWasAdded.Text = AStock.DatePostWasAdded;
            txtPriceTag.Text = AStock.PriceTag.ToString();
            txtModel.Text = AStock.Vmodel.ToString();
            chkIsSold.Checked = AStock.Sold;
            lblError.Text = "";
        }
        else
        {
            
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}
