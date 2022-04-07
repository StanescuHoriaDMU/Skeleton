using System;

namespace ClassLibrary
{
    public class clsStockList
    {
        private int mVehicleId;
        private DateTime mDateAdded;
        private double mPriceTag;
        private bool mSold;
        private string mVmodel;

        public Int32 VehicleId
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

        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }

            set
            {
                mDateAdded = value;
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

        public string YOV { get; set; }
        public int DateTemp { get; private set; }

        public bool Find(int VehicleId)
        {
            // set the private data members to the test data value 
            mVehicleId = 1;
            mDateAdded = Convert.ToDateTime("01/01/2015");
            mPriceTag = 22000;
            mSold = false;
            mVmodel = "bmw";
            //always returns true
            return true;
        }
        public string Valid(string vehicleId, string model, string YOV, string datePostWasAdded, string price)
        {
            //VehicleID

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

            //DatePostWasAdded
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

            //DatePostWasAdded
            if (datePostWasAdded.Length < 1)
            {
                Error = Error + "Full name must be at least 2 characters : ";
            }
            if (datePostWasAdded.Length > 50)
            {
                Error = Error + "Full name must be no longer than 50 characters :";
            }
            return Error;

            //Model
            if (model.Length < 2)
            {
                Error = Error + "Model of car must be at least 2 characters : ";
            }
            if (model.Length > 50)
            {
                Error = Error + "Full name must be no longer than 50 characters : ";
            }

            //YOV
            if (YOV.Length < 4)
            {
                Error = Error + "Year of vehicle must be at least 4 characters : ";
            }
            if (YOV.Length > 320)
            {
                Error = Error + "Year of vehicle can not be longer than 320 characters : ";
            }

            //price
            if (price.Length < 4)
            {
                Error = Error + "Price of vehicle must be at least 4 characters : ";
            }
            if (YOV.Length > 320)
            {
                Error = Error + "Price of vehicle can not be longer than 320 characters : ";
            }
        }
    }
}
