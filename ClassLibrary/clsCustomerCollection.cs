using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        private List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList {
            get
            {
                return mCustomerList;
            }
            set 
            {
                mCustomerList = value;
            } 
        }
        public int Count { 
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }
        public clsCustomerCollection()
        {
            
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_CustomerManagement_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@EmailAdress", mThisCustomer.EmailAdress);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@VerifiedCustomer", mThisCustomer.VerifiedCustomer);
            return DB.Execute("sproc_CustomerManagement_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserId", mThisCustomer.UserId);
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@EmailAdress", mThisCustomer.EmailAdress);
            DB.AddParameter("@DateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@VerifiedCustomer", mThisCustomer.VerifiedCustomer);
            DB.Execute("sproc_CustomerManagement_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("UserId", mThisCustomer.UserId);
            DB.Execute("sproc_CustomerManagement_Delete");
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.UserId = Convert.ToInt32(DB.DataTable.Rows[Index]["userId"]);
                ACustomer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                ACustomer.EmailAdress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAdress"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                ACustomer.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                ACustomer.VerifiedCustomer = Convert.ToBoolean(DB.DataTable.Rows[Index]["VerifiedCustomer"]);
                mCustomerList.Add(ACustomer);
                Index++;
            }
        }

        public void ReportByFullName(string FullName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", FullName);
            DB.Execute("sproc_CustomerManagement_FilterByFullName");
            PopulateArray(DB);
        }
    }
}