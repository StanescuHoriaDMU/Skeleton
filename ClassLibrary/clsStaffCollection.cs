using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {



        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@IsEmployed", mThisStaff.IsEmployed);
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@UserName", mThisStaff.UserName);
            DB.AddParameter("@DOB", mThisStaff.DOB);
            DB.AddParameter("@EmailAddress", mThisStaff.EmailAddress);

            return DB.Execute("sproc_tlbStaff_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("StaffID", mThisStaff.StaffID);
            DB.AddParameter("@IsEmployed", mThisStaff.IsEmployed);
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@UserName", mThisStaff.UserName);
            DB.AddParameter("@DOB", mThisStaff.DOB);
            DB.AddParameter("@EmailAddress", mThisStaff.EmailAddress);
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByFullName(String FullName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FullName", FullName);
            DB.Execute("Sproc_tblStaff_FilterByFullName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.IsEmployed = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsEmployed"]);
                AStaff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AStaff.UserName = Convert.ToString(DB.DataTable.Rows[Index]["UserName"]);
                AStaff.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AStaff.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                mStaffList.Add(AStaff);
                Index++;
            }
        }

        



    }   
}