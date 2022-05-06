using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing1
{
    [TestClass]
    public class tstStockList
    {
        

        [TestMethod]

        public void InstanceOK()
        {
            //creat a new instance of the new class we want to create 
            clsStockList aStock = new clsStockList();
            //test to see that it exists 
            Assert.IsNotNull(aStock);
        }

        [TestMethod]
        public void ModelOK()
        {
            // create a new instance of the class we want to create 
            clsStockList aStock = new clsStockList();
            //create a variable of TestData and store it with a hardcoded string value 
            String TestData = "BMW 2 Series M-Sport";
            //assign the data to the property 
            aStock.Vmodel = TestData;
            //test to see the two values are the same
            Assert.AreEqual(aStock.Vmodel, TestData);
        }
        [TestMethod]
        public void DatePostWasAddedOK()
        {
            // create a new instance of the class we want to create 
            clsStockList aStock = new clsStockList();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            aStock.DatePostWasAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.DatePostWasAdded, TestData);
        }
        [TestMethod]
        public void YearOfVehicleOK()
        {
            // create a new instance of the class we want to create 
            clsStockList aStock = new clsStockList();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            aStock.YOV = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.YOV, TestData);
        }
        [TestMethod]
        public void PriceOfVehicleOK()
        {
            // create a new instance of the class we want to create 
            clsStockList aStock = new clsStockList();
            // create some test data to assign to the property
            Double TestData = 42229.99;
            //assign the data to the property 
            aStock.PriceTag = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.PriceTag, TestData);
        }
        [TestMethod]
        public void IsSoldOK()
        {
            // create a new instance of the class we want to create 
            clsStockList aStock = new clsStockList();
            // create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            aStock.Sold = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Sold, TestData);
        }


        [TestMethod]
        public void VehicleIdOK()
        {
            //create an instance of the class we want to create
            clsStockList AStock = new clsStockList();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AStock.VehicleId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.VehicleId, TestData);
        }

        [TestMethod]
        public void VehicleModelPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockList AStock = new clsStockList();
            //create some test data
            String TestData = "ExampleText";
            //assign the data to the property
            AStock.Vmodel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Vmodel, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStockList AStock = new clsStockList();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 VehicleId = 5;
            //invoke the method
            Found = AStock.Find(VehicleId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestVehicleIDFound()
        {
            //create an instance of the class we want to create
            clsStockList AStock = new clsStockList();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int VehicleId = 5;
            //invoke the method
            Found = AStock.Find(VehicleId);
            //check the vehicle id
            if (AStock.VehicleId != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDatePostWasAddedFound()
        {
            //create an instance of the class we want to create
            clsStockList AStock = new clsStockList();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int VehicleId = 1;
            //DateTime DatePostWasAdded = DateTime.Now.Date;
            //invoke the method
            Found = AStock.Find(VehicleId);
            //check the vehicle id
            if (AStock.DatePostWasAdded != DateTime.Now.Date)
                //check the property
                if (AStock.DatePostWasAdded != DateTime.Now.Date) 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceTagFound()
        {
            //create an instance of the class we want to create
            clsStockList AStock = new clsStockList();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int vehicleId = 1;
            //invoke the method
            Found = AStock.Find(vehicleId);
            //check the property
            if (AStock.PriceTag != 12000)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
    }
