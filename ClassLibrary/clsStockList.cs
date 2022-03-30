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

        //function for the public validation method
         public string Valid(string VehicleId,
                             DateTime DateAdded,
                             string PriceTag,
                             string Sold,
                             string VModel);
        
        //this function acceots 5 parameters for validation 
        //the function returns a string containing any error message 
        //if no errors found then blank string is returned
    }
}