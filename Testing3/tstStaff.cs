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

        public void DateOfBirthOK()
        {
            //create an instance of the class we want to  create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateOfBirth, TestData);


        }

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


        public class clsStaff
        {
            public bool Active { get; set; }
            public DateTime DateOfBirth { get; internal set; }
            public int StaffID { get; internal set; }
            public string FullName { get; internal set; }
            public string EmailAddress { get; internal set; }
            public string UserName { get; internal set; }
        }
    }
}
