using System;

namespace Testing6
{
    public class clsOrder
    {
        internal DateTime soldDate;

        public int purchaseID { get; internal set; }
        public int userID { get; internal set; }
        public int vehicleID { get; internal set; }
        public bool dispatched { get; internal set; }
        public string userAddress { get; internal set; }
    }
}