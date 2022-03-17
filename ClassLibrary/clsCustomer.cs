using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private int mUserId;
        private string mFullName;
        private string mEmailAdress;
        private DateTime mDateOfBirth;
        private string mUsername;
        private Boolean mVerifiedCustomer;
        public clsCustomer()
        {
        }

        public bool VerifiedCustomer
        {
            get
            {
                return mVerifiedCustomer;
            }
            set
            {
                mVerifiedCustomer = value;
            }
        }
        public DateTime DateOfBirth {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }
        public int UserId {
            get
            {
                return mUserId;
            }
            set
            {
                mUserId = value;
            }
        }
        public string FullName {
            get
            {
                return mFullName;
            }
            set
            {
                mFullName = value;
            }
        }
        public string EmailAdress {
            get
            {
                return mEmailAdress;
            }
            set
            {
                mEmailAdress = value;
            }
        }
        public string Username
        {
            get
            {
                return mUsername;
            }
            set
            {
                mUsername = value;
            }
        }

        public bool Find(int userId)
        {
            // mUserId = 1;
            // mFullName = "Ana Maria";
            // mEmailAdress = "anamaria@yahoo.com";
            // mDateOfBirth = Convert.ToDateTime("26/01/2001");
            // mUsername = "anamaria";
            // mVerifiedCustomer = true;
            // return true;

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@userId", userId);
            DB.Execute("sproc_CustomerManagement_FilterByUserId");
            if(DB.Count == 1)
            {
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["userId"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mEmailAdress = Convert.ToString(DB.DataTable.Rows[0]["EmailAdress"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mVerifiedCustomer = Convert.ToBoolean(DB.DataTable.Rows[0]["VerifiedCustomer"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string fullName, string emailAdress, string dateOfBirth, string username)
        {
            string Error = "";
            DateTime DateTemp;
            try
            {
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp > DateTime.Now.Date.AddYears(-18))
                {
                    Error = Error + "You must be over 18: ";
                }
                if (DateTemp <= DateTime.Now.Date.AddYears(-100))
                {
                    Error = Error + "The date cannot be more than 100 years ago : ";
                }
            }
            catch
            {
                Error = Error + "The date is not valid";
            }
            
            if(fullName.Length == 0)
            {
                Error = Error + "Fullname cannot be empty";
            }
            if(fullName.Length > 50)
            {
                Error = Error + "Fullname must be less than 50 characters";
            }

            if (emailAdress.Length == 0)
            {
                Error = Error + "emailAdress cannot be empty";
            }
            if (emailAdress.Length > 50)
            {
                Error = Error + "emailAdress must be less than 50 characters";
            }
            if (username.Length == 0)
            {
                Error = Error + "username cannot be empty";
            }
            if (username.Length > 50)
            {
                Error = Error + "username must be less than 50 characters";
            }
            return Error;
        }
    }
}