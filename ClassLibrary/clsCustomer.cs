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
    }
}