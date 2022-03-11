using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool VerifiedCustomer { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string EmailAdress { get; set; }
        public string Username { get; set; }
    }
}