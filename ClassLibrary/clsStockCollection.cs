using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    class clsStockCollection
    {
        public List<clsStockList> StockList;
        public List<clsStockList> ThisStock;
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();
        private List<clsStockList> mStockList;

        public List<clsStockList> StaffList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
    }
}
