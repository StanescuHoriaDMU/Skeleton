/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStockCollection allStock = new ClassLibrary.clsStockCollection(); // for some reasom this is not recognising the clsStockCollection
            Assert.IsNotNull(allStock);

        }
        [TestMethod]
            public void StockListOK() //
            {
                clsStockCollection allStock = new clsStockCollection();
                List<clsStockList> TestList = new List<clsStockList>();
                clsStockList TestItem = new clsStockList();
                TestItem.VehicleId = 1;
                TestItem.DatePostWasAdded = Convert.ToDateTime("01/01/2016");
                TestItem.PriceTag = 12000;
                TestItem.Sold = false;
                TestItem.Vmodel = "BMW 1 - Series";
                TestItem.YOV = Convert.ToDateTime("01/01/2013");
                TestList.Add(TestItem);
                allStock.stockList = TestList;
                Assert.AreEqual(allStock.stockList, TestList);
            }

            [TestMethod]
            public void ThisStockPropertyOK() //
            {
            clsStockCollection allStock = new clsStockCollection();
                List<clsStockList> TestList = new List<clsStockList>();
                clsStockList TestItem = new clsStockList();
                TestItem.VehicleId = 1;
                TestItem.DatePostWasAdded = Convert.ToDateTime("01/01/2016");
                TestItem.PriceTag = 12000;
                TestItem.Sold = false;
                TestItem.Vmodel = "BMW 1 - Series";
                TestItem.YOV = Convert.ToDateTime("01/01/2013"); ;
                TestList.Add(TestItem);
                allStock.StockList = TestList;
                Assert.AreEqual(allStock.ThisStock, TestList);
            }

        [TestMethod]
        public void ListAndCountOK()//
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 1;
            TestItem.FullName = "Tyler Ellis";
            TestItem.EmailAddress = "tylerellis31@gmail.com";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.UserName = "ellistyler123";
            TestItem.IsEmployed = true;
            TestList.add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffID = 1;
            TestItem.FullName = "Tyler Ellis";
            TestItem.EmailAddress = "tylerellis31@gmail.com";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.UserName = "ellistyler123";
            TestItem.IsEmployed = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaff.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.StaffID = 1;
            TestItem.FullName = "Tyler Ellis";
            TestItem.EmailAddress = "tylerellis31@gmail.com";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.UserName = "ellistyler123";
            TestItem.IsEmployed = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            TestItem.FullName = "Joe bloggs";
            TestItem.EmailAddress = "JoeBloggs@gmail.com";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.UserName = "JBloggs123";
            TestItem.IsEmployed = false;
            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisCustomerFind(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisCustomer, TestItem);
        }

        [TestMethod]

        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.FullName = "Tyler Ellis";
            TestItem.EmailAddress = "tylerellis31@gmail.com";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.UserName = "ellistyler123";
            TestItem.IsEmployed = true;
            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]

        public void ReportByFullNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByFullName("");
            Assert.AreEqual(AllStaff.Count, FilteredCustomers.Count);
        }

        [TestMethod]

        public void ReportByFullNameNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByFullName("xxxx xxxx");
            Assert.AreEqual(0, FilteredStaff.Count);
        }


        [TestMethod]

        public void ReportByFullNameDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaff.ReportByFullName("Tyler Ellis");
            if (FilteredStaff.count == 3)
            {
                if (FilteredStaff.StaffList[0].StaffID != 1)
                {
                    OK = false;
                }
                if (FilteredStaff.CustomerList[1].StaffID != 2)
                {
                    OK = false;
                }
                if (FilteredStaff.CustomerList[2].StaffID != 3)
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

 */