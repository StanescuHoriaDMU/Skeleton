using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing1
{
    [TestClass]
    public class TstStockList
    {

        string VehicleId = "1";
        string Model = "bmw";
        string YOV = DateTime.Now.Date.ToString("07/01/2015");
        string DatePostWasAdded = DateTime.Now.Date.ToString("07/01/2015");
        string Price = "22000";
        

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
        public void DatePostWasCreatedOK()
        {
            // create a new instance of the class we want to create 
            clsStockList aStock = new clsStockList();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            aStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.DateAdded, TestData);
        }

        [TestMethod]
        public void YearOfVehicleOK()
        {
            // create a new instance of the class we want to create 
            clsStockList aStock = new clsStockList();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            aStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.DateAdded, TestData);
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
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsStockList aStock = new clsStockList();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int vehicleId = 21;
            //invoke the method 
            Found = aStock.Find(vehicleId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestVehcicleIdNotFound()
        {
            clsStockList aStock = new clsStockList();
            Boolean Found = false;
            Boolean OK = true;
            int VehicleId = 1;
            Found = aStock.Find(VehicleId);
            if (aStock.VehicleId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostAddedFound()
        {
            clsStockList aStock = new clsStockList();
            Boolean Found = false;
            Boolean OK = true;
            int VehicleId = 1;
            Found = aStock.Find(VehicleId);
            if (aStock.DateAdded != Convert.ToDateTime("07/01/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestModelFound()
        {
            clsStockList aStock = new clsStockList();
            Boolean Found = false;
            Boolean OK = true;
            int VehicleId = 1;
            Found = aStock.Find(VehicleId);
            if (aStock.Vmodel != "bmw")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestYearOfVehicleFound()
        {
            clsStockList aStock = new clsStockList();
            Boolean Found = false;
            Boolean OK = true;
            int VehicleId = 1;
            Found = aStock.Find(VehicleId);
            if (aStock.YOV != "01/01/2015")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsStockList aStock = new clsStockList();
            Boolean Found = false;
            Boolean OK = true;
            int VehicleId = 1;
            Found = aStock.Find(VehicleId);
            if (aStock.PriceTag != 22000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void IsSoldFound()
        {
            clsStockList aStock = new clsStockList();
            Boolean Found = false;
            Boolean OK = true;
            int VehicleId = 1;
            Found = aStock.Find(VehicleId);
            if (aStock.Sold != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //cretae a new instance of the class we want to create 
            clsStockList aStock = new clsStockList();
            //string variable to store any error message 
            string Error = "";
            //invoke the method 
            Error = aStock.Valid(VehicleId, Model, YOV, DatePostWasAdded, Price);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VehicleIdMin()
        {
            //cretae a new instance of the class we want to create 
            clsStockList aStock = new clsStockList();
            //string variable to store any error message 
            string Error = "";
            //test data to pass the method 
            string VehicleId = "";//should trigger an error 
            //invoke the method 
            Error = aStock.Valid(VehicleId, Model, YOV, DatePostWasAdded, Price);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void VehicleModelMax()
        {
            clsStockList aStock = new clsStockList();
            String Error = "";
            string Model = "1111111111111111111111111111111111111111111111111a";
            Error = aStock.Valid(VehicleId, Model, YOV, DatePostWasAdded, Price);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]

        public void vehicleModelMaxPlusOne()
        {
            clsStockList aStock = new clsStockList();
            String Error = "";
            string Model = "1111111111111111111111111111111111111111111111111aEeee";
            Error = aStock.Valid(VehicleId, Model, YOV, DatePostWasAdded, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void VehicleModelMaxLessOne()
        {
            clsStockList aStock = new clsStockList();
            String Error = "";
            string Model = "111111111111111111111111111111111111111111111111";
            Error = aStock.Valid(VehicleId, Model, YOV, DatePostWasAdded, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void VehicleModelMinPlusOne()
        {
            clsStockList aStock = new clsStockList();
            String Error = "";
            string Model = "123456789012345"; // i have chosen that i need min to be 15 characters
            Error = aStock.Valid(VehicleId, Model, YOV, DatePostWasAdded, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void VehicleModelMid()
        {
            clsStockList aStock = new clsStockList();
            String Error = "";
            string Model = "bmw 1 series";
            Error = aStock.Valid(VehicleId, Model, YOV, DatePostWasAdded, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void VehicleModelMaxExtreme()
        {
            clsStockList aStock = new clsStockList();
            String Error = "";
            string Model = "";
            Model = Model.PadRight(500, 'a');
            Error = aStock.Valid(VehicleId, Model, YOV, DatePostWasAdded, Price);
            Assert.AreEqual(Error, "");
        }
    }
}
