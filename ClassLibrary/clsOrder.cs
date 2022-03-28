using System;

namespace Testing6
{
    public class clsOrder
    {
        public DateTime soldDate;

        public int purchaseID { get; set; }
        public int userID { get; set; }
        public int vehicleID { get; set; }
        public bool dispatched { get;  set; }
        public string userAddress { get; set; }
    }
}