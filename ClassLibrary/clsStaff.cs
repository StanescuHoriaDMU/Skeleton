using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        private Int32 mStaffID;
        private String mFullName;
        private String mEmailAddress;
        private String mUserName;
        private DateTime mDOB;
        private Boolean mIsEmployed;
        

        public Int32 StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property
                mStaffID = value;
            }
        }

        public String FullName
        {
            get
            {
                //this line of code sends data out of the property
                return mFullName;
            }
            set
            {
                //this line of code allows data into the property
                mFullName = value;
            }
        }

        public String EmailAddress
        {
            get
            {
                //this line of code sends data out of the property
                return mEmailAddress;
            }
            set
            {
                //this line of code allows data into the property
                mEmailAddress = value;
            }
        }

        public String UserName
        {
            get
            {
                //this line of code sends data out of the property
                return mUserName;
            }
            set
            {
                //this line of code allows data into the property
                mUserName = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                //this line of code sends data out of the property
                return mDOB;
            }
            set
            {
                //this line of code allows data into the property
                mDOB = value;
            }
        }

        public Boolean IsEmployed
        {
            get
            {
                //this line of code sends data out of the property
                return mIsEmployed;
            }
            set
            {
                //this line of code allows data into the property
                mIsEmployed = value;
            }
        }

        public bool Find(int staffID)
        {
            //create an instance of the data onnection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff no to search for
            DB.AddParameter("@StaffID", staffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByAddressNo");
            //if one record is found (there should either be one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mIsEmployed = Convert.ToBoolean(DB.DataTable.Rows[0]["IsEmployed"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                return true;
            }
            //if no record was found
            else 
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}
    
