using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        private Int32 mStaffID;

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



        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public DateTime DOB { get; set; }
        public bool Active { get; set; }

        public bool Find(int staffID)
        {
            mStaffID = 21;
            return true;
        }
    }
}
    
