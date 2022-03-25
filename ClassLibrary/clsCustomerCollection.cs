using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        private List<clsCustomer> mCustomerList = new List<clsCustomer>();
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
        public clsCustomer ThisCustomer { get; set; }
        public clsCustomerCollection()
        {
            int Index = 0;
            int RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_CustomerManagement_SelectAll");
            RecordCount = DB.Count;
            while(Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.UserId = Convert.ToInt32(DB.DataTable.Rows[0]["userId"]);
                ACustomer.FullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                ACustomer.EmailAdress = Convert.ToString(DB.DataTable.Rows[0]["EmailAdress"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                ACustomer.Username = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                ACustomer.VerifiedCustomer = Convert.ToBoolean(DB.DataTable.Rows[0]["VerifiedCustomer"]);
                mCustomerList.Add(ACustomer);
                Index++;
            }
        }
    }
}