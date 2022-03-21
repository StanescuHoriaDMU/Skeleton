using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
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
            AStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Active, TestData);
        
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
            String TestData = "Joe Bloggs";
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
            String TestData = "JoeBloggs@gmail.com";
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
            String TestData = "JBloggs123";
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
            Int32 StaffID = 21;
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
            Int32 StaffID = 21;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the address no
            if (AStaff.StaffID != 21)
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
            Int32 StaffID = 21;
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
            Int32 StaffID = 21;
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
            Int32 StaffID = 21;
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
            Int32 StaffID = 21;
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
            Int32 StaffID = 21;
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

    }
}
