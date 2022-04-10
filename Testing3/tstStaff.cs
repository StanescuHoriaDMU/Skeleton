using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing3
{
    [TestClass]
    public class tstStaff
    {

        string StaffID = "2";
        string FullName = "Joe bloggs";
        string UserName = "Bloggs123";
        string EmailAddress = "JoeBloggs222@gmail.com";
        string DOB = DateTime.Now.Date.ToString();


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void isEmployedOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.IsEmployed = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.IsEmployed, TestData);

        }

        [TestMethod]
        public void DateOfBirthOK()
        {
            //create an instance of the class we want to  create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DOB, TestData);


        }

        [TestMethod]
        public void StaffIdOK()
        {
            //create an instance of the property we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property;
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);


        }

        [TestMethod]
        public void FullNameOK()
        {
            //create an instance of the property we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property;
            String TestData = "Tyler Ellis";
            //assign the data to the property
            AStaff.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.FullName, TestData);



        }

        [TestMethod]
        public void EmailAddressOK()
        {
            //create an instance of the property we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property;
            String TestData = "ellisaustintyler@gmail.com";
            //assign the data to the property
            AStaff.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.EmailAddress, TestData);



        }

        [TestMethod]
        public void UserNameOK()
        {
            //create an instance of the property we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property;
            String TestData = "TylerEllis123";
            //assign the data to the property
            AStaff.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.UserName, TestData);



        }

        [TestMethod]
        public void FindMethodOK()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestAddressNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is okay (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the address no
            if (AStaff.StaffID != 1)
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestFullNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.FullName != "Tyler Ellis")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.EmailAddress != "ellisaustintyler@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDOBFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.DOB != Convert.ToDateTime("28/05/2001"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestUserNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.UserName != "TylerEllis123")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestIsEmployedFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the property
            if (AStaff.IsEmployed != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");


        }

        [TestMethod]

        public void UserNameMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string UserName = "uname";
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void UserNameMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string UserName = "alexandraisbestt";
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void UserNameMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string UserName = "four";
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void UserNameMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string UserName = "oneTwoThreeFouraa";
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void UserNameMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string UserName = "oneTwoThreeFour";
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void UserNameMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string UserName = "aaaaaa";
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void UserNameMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string UserName = "AAAAAAAA";
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void UserNameMaxExtreme()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string UserName = "";
            UserName = UserName.PadRight(500, 'a');
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DOBExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-200);
            string DOB = TestDate.ToString();
            Error = AStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DOBMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-101);
            string DOB = TestDate.ToString();
            Error = AStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DOBMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100)
            string DOB = TestDate.ToString();
            Error = AStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DOBMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-50)
            string DOB = TestDate.ToString();
            Error = AStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DOBMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-99);
            string DOB = TestDate.ToString();
            Error = AStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DOBExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(200);
            string DOB = TestDate.ToString();
            Error = AStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DOBMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DOB = TestDate.ToString();
            Error = AStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DOBMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DOB = TestDate.ToString();
            Error = AStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DOBMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string DOB = TestDate.ToString();
            Error = AStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DOBInvalidData()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string DOB = "this is not a date!";
            Error = AStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }







        [TestMethod]

        public void FullNameMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "aa";
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FullNameMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(50, 'a');
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FullNameMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "f";
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void FullNameMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(51, 'a');
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void FullNameMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(49, 'a');
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FullNameMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "aaa";
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FullNameMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(25, 'a');
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FullNameMaxExtreme()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(500, 'a');
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }







        [TestMethod]

        public void EmailAddressMin()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string EmailAddress = "a@a";
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void EmailAddressMax()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(320, 'a');
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void EmailAddressMinLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string EmailAddress = "a@";
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void EmailAddressMaxPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string UserName = "";
            UserName = UserName.PadRight(321, 'a');
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void EmailAddressMaxLessOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string UserName = "";
            UserName = UserName.PadRight(319, 'a');
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void EmailAddressMinPlusOne()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string UserName = "aa@a";
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void EmailAddressMid()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string UserName = "";
            UserName = UserName.PadRight(160, 'a');
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FullNameMaxExtreme()
        {
            clsStaff aStaff = new clsStaff();
            String Error = "";
            string UserName = "";
            UserName = UserName.PadRight(500, 'a');
            Error = aStaff.Valid(StaffID, FullName, UserName, EmailAddress, DOB);
            Assert.AreNotEqual(Error, "");
        }





    }
}




