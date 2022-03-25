using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        string FullName = "Ana Maria";
        string EmailAdress = "anamaria@yahoo.com";
        string DateOfBirth = DateTime.Now.Date.AddYears(-20).ToString();
        string Username = "anamaria";
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
        [TestMethod]
        public void ValidMethodOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-19);
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-18);
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-17);
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateOfBirth = TestDate.ToString();
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string DateOfBirth = "this is not a date!";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string FullName = "";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string FullName = "a";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string FullName = "aa";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
        public void FullNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
        public void FullNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreNotEqual(Error, "");
        }
        public void FullNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string FullName = "aaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAdressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string EmailAdress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
        public void EmailAdressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string EmailAdress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
        public void EmailAdressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string EmailAdress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreNotEqual(Error, "");
        }
        public void EmailAdressMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string EmailAdress = "aaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UsernameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Username = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
        public void UsernameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Username = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
        public void UsernameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Username = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreNotEqual(Error, "");
        }
        public void UsernameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Username = "aaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(FullName, EmailAdress, DateOfBirth, Username);
            Assert.AreEqual(Error, "");
        }
    }
}
