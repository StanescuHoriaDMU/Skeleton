using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void VerifiedCustomerPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.VerifiedCustomer = TestData;
            Assert.AreEqual(ACustomer.VerifiedCustomer, TestData);
        }
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateOfBirth = TestData;
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }
        [TestMethod]
        public void UserIdPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            int TestData = 1;
            ACustomer.UserId = TestData;
            Assert.AreEqual(ACustomer.UserId, TestData);
        }
        [TestMethod]
        public void FullNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Ana Maria";
            ACustomer.FullName = "Ana Maria";
            Assert.AreEqual(ACustomer.FullName, TestData);
        }
        [TestMethod]
        public void EmailAdressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "anamaria@yahoo.com";
            ACustomer.EmailAdress = TestData;
            Assert.AreEqual(ACustomer.EmailAdress, TestData);
        }
        [TestMethod]
        public void UsernamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "anamaria21";
            ACustomer.Username = TestData;
            Assert.AreEqual(ACustomer.Username, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            int UserId = 1;
            Found = ACustomer.Find(UserId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int UserId = 1;
            Found = ACustomer.Find(UserId);
            if (ACustomer.EmailAdress != "anamaria@yahoo.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFulllNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int UserId = 1;
            Found = ACustomer.Find(UserId);
            if (ACustomer.FullName != "Ana Maria")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int UserId = 1;
            Found = ACustomer.Find(UserId);
            if (ACustomer.EmailAdress != "anamaria@yahoo.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfBirthFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int UserId = 1;
            Found = ACustomer.Find(UserId);
            if (ACustomer.DateOfBirth != Convert.ToDateTime("26/01/2001"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUserNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int UserId = 1;
            Found = ACustomer.Find(UserId);
            if (ACustomer.Username != "anamaria")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestVerifiedCustomerFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            int UserId = 1;
            Found = ACustomer.Find(UserId);
            if (ACustomer.VerifiedCustomer != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
