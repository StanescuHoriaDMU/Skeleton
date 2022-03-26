using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstOrders
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //}
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void PurchaseIDPropertyOk()
        {
            clsOrder AnOrder =new clsOrder();
            int TestData=int.MaxValue;
            AnOrder.purchaseID = TestData;
            Assert.AreEqual(AnOrder.purchaseID, TestData);
        }

        [TestMethod]
        public void UserIDPropertyOk()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = int.MaxValue;
            AnOrder.userID = TestData;
            Assert.AreEqual(AnOrder.userID, TestData);
        }

        [TestMethod]
        public void VehicleIDPropertyOk()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = int.MaxValue;
            AnOrder.vehicleID = TestData;
            Assert.AreEqual(AnOrder.vehicleID, TestData);
        }

        [TestMethod]
        public void DispatchedPropertyOk()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.dispatched = TestData;
            Assert.AreEqual(AnOrder.dispatched, TestData);
        }

        [TestMethod]
        public void UserAddressPropertyOk()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "Address";
            AnOrder.userAddress = TestData;
            Assert.AreEqual(AnOrder.userAddress, TestData);
        }

        [TestMethod]
        public void SoldDatePropertyOk()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.soldDate = TestData;
            Assert.AreEqual(AnOrder.soldDate, TestData);
        }
    }
}
