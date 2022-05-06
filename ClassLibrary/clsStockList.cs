using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class clsStockList
{
    private int mVehicleId;
    private DateTime mDatePostWasAdded;
    private double mPriceTag;
    private bool mSold;
    private string mVmodel;
    private DateTime mYear;

    public int VehicleId
    {
        get
        {
            //this line of code sends data out of the property
            return mVehicleId;
        }
        set
        {
            //this line of code allows data into the property
            mVehicleId = value;
        }
    }

    public DateTime DatePostWasAdded
    {
        get
        {
            return mDatePostWasAdded;
        }

        set
        {
            mDatePostWasAdded = value;
        }
    }

    public double PriceTag
    {
        get
        {
            return mPriceTag;
        }

        set
        {
            mPriceTag = value;
        }
    }

    public Boolean Sold
    {
        get
        {
            return mSold;
        }

        set
        {
            mSold = value;
        }
    }

    public string Vmodel
    {
        get
        {
            return mVmodel;
        }

        set
        {
            mVmodel = value;
        }
    }

    public DateTime YOV
    {
        get
        {
            return mYear;
        }

        set
        {
            mYear = value;
        }
    }
  

  public bool Find(int VehicleId)
    {
        //create an instance of the data connection
        clsDataConnection DB = new clsDataConnection();
        //add the parameter for the shoe id to search for
        DB.AddParameter("@VehicleId", VehicleId);
        //execute the stored procedure
        DB.Execute("sproc_tblStock_FilterByVehicleId");
        //if one record is found (there should be either one or zero)
        if (DB.Count == 1)
        {
            //copy the data from the database to the private data members
            mVehicleId = Convert.ToInt32(DB.DataTable.Rows[0]["VehicleId"]);
            mDatePostWasAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePostWasAdded"]);
            mVmodel = Convert.ToString(DB.DataTable.Rows[0]["Vehicle Model"]);
            mPriceTag = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
            mYear = Convert.ToDateTime(DB.DataTable.Rows[0]["Year Of Vehicle"]);
            mSold = Convert.ToBoolean(DB.DataTable.Rows[0]["Is Sold"]);

            //return that everything worked OK
            return true;
        }
        //if no record is found
        else
        {
            //return false indicating a problem
            return false;
        }
    }



    public string Valid(string vehicleId, string model, string YOV, string datePostWasAdded, string price)
    {
        String Error = "";
        DateTime DateTemp;
        DateTime DateMin;


        DateMin = DateTime.Now.Date;
        DateMin = DateMin.AddYears(-100);


        if (Vmodel.Length == 4) //usernameMinLessOne
        {
            Error = Error + "Username must be at least 5 characters : ";
        }
        if (Vmodel.Length > 50)
        {
            Error = Error + "Username can not be longer than 50 characters";
        }

        try
        {
            DateTemp = Convert.ToDateTime(this.YOV);
            if (DateTemp < DateMin)
            {
                Error = Error + "Your year of vehicle cannot be over 100 years in the past :";
            }
            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "Your year of vehicle can not be in the future :";
            }

        }
        catch
        {
            Error = Error + "The date was not a valid date : ";
        }

        try
        {
            DateTemp = Convert.ToDateTime(DatePostWasAdded);
            if (DateTemp < DateMin)
            {
                Error = Error + "Your advert cannot be over 100 years in the past :";
            }
            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "Your advert can not be in the future :";
            }

        }
        catch
        {
            Error = Error + "The date was not a valid date : ";
        }
        if (PriceTag < 500 )
        {
            Error = Error + "price can not be less than 500 : ";
        }

        if (PriceTag < 7)
        {
            Error = Error + "price can not be 7 chracacters long";
        }
        if (PriceTag == 0)
        {
            Error = Error + "price value can not be 0";
        }

        if (VehicleId < 0)
        {
            Error = Error + "The staffID must be greater than 0 : ";
        }
        if (VehicleId > 10000)
        {
            Error = Error + "The staffID cannot be greater than 10,000 : ";
        }


        return Error;
    }

}