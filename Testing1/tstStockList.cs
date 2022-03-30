using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing1
{
    [TestClass]
    public class TstStockList
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creat a new instance of the new class we want to create 
            clsStockList aStock = new clsStockList();
            //test to see that it exists 
            Assert.IsNotNull(aStock);
        }
        
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

        public void DatePostWasCreated()
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

        public void YearOfVehicle()
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

        public void PriceOfVehicle()
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

        public void IsSold()
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

        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsStockList aStock = new clsStockList();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 id = 21;
            //invoke the method 
            Found = aStock.Find(id);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

    }
    }
