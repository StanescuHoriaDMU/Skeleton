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
        [TestMethod]
        public void AddMethodOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.FullName = "Ana Maria";
            TestItem.EmailAdress = "anamaria@yahoo.com";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Username = "anamaria";
            TestItem.VerifiedCustomer = true;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.UserId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.FullName = "Ana Maria";
            TestItem.EmailAdress = "anamaria@yahoo.com";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Username = "anamaria";
            TestItem.VerifiedCustomer = true;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.UserId = PrimaryKey;
            TestItem.FullName = "Ana Banana";
            TestItem.EmailAdress = "banana@yahoo.com";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Username = "bananaa";
            TestItem.VerifiedCustomer = false;
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.FullName = "Ana Maria";
            TestItem.EmailAdress = "anamaria@yahoo.com";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.Username = "anamaria";
            TestItem.VerifiedCustomer = true;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.UserId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByFullNameMethodOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByFullName("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByFullName("xxx xxxxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByFUllNameDataFount()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByFullName("ad");
            if(FilteredCustomers.Count == 3)
            {
                if (FilteredCustomers.CustomerList[0].UserId != 9)
                {
                    OK = false;
                }
                if(FilteredCustomers.CustomerList[1].UserId != 10)
                {
                    OK = false;
                }
                if(FilteredCustomers.CustomerList[2].UserId != 11)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
