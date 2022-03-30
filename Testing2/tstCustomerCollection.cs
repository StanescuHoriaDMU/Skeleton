using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.UserId = 1;
            TestItem.FullName = "Ana Maria";
            TestItem.EmailAdress = "anamaria@yahoo.com";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Username = "anamaria";
            TestItem.VerifiedCustomer = true;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        
        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            TestItem.UserId = 1;
            TestItem.FullName = "Ana Maria";
            TestItem.EmailAdress = "anamaria@yahoo.com";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Username = "anamaria";
            TestItem.VerifiedCustomer = true;
            AllCustomers.ThisCustomer = TestItem;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.UserId = 1;
            TestItem.FullName = "Ana Maria";
            TestItem.EmailAdress = "anamaria@yahoo.com";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Username = "anamaria";
            TestItem.VerifiedCustomer = true;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}
