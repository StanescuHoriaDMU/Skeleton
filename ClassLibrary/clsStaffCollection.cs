using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        private List<clsStaff> mStaffList = new List<clsStaff>();
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
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
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