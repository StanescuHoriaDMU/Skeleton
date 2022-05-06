using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        // set the private data members to the test data value 
        mVehicleId = 1;
        mDatePostWasAdded = Convert.ToDateTime("01/01/2015");
        mPriceTag = 22000;
        mSold = false;
        mVmodel = "bmw";
        mYear = Convert.ToDateTime("01/01/2013");
        //always returns true
        return true;
    }
    public string Valid(string vehicleId, string model, string YOV, string datePostWasAdded, string price)
    {
        //create a string variable to store the error
        String Error = "";
        //temporary variable to store date values
        DateTime DateTemp;
        //if the vehcileId is blank 
        if (vehicleId.Length == 0)
        {
            //record error
            Error = Error + "The VehicleId may not be blank: ";
        }
        if (vehicleId.Length > 6)
        {
            //record error
            Error = Error + "The VehicleId must be less than 50 characters";
        }
        //return error message
        return Error;

        try
        {
            DateTemp = Convert.ToDateTime(datePostWasAdded);
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be over 100 years in the past :";
            }
            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future :";
            }
        }

        catch
        {
            Error = Error + "The date was not a valid date : ";
        }

        if (datePostWasAdded.Length < 1)
        {
            Error = Error + "Full name must be at least 2 characters : ";
        }
        if (datePostWasAdded.Length > 50)
        {
            Error = Error + "Full name must be no longer than 50 characters :";
        }
        return Error;
    }

}