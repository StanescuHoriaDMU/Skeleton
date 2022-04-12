using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);

        }

        [TestMethod]
        public void StaffListOk() //
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
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]

        public void CountStaffOK() //
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 SomeCount = 0;
            AllStaff.Count = SomeCount;
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }


        [TestMethod]
        public void ThisStaffPropertyOK() //
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.StaffID = 1;
            TestStaff.FullName = "Tyler Ellis";
            TestStaff.EmailAddress = "tylerellis31@gmail.com";
            TestStaff.DOB = DateTime.Now.Date;
            TestStaff.UserName = "ellistyler123";
            TestStaff.IsEmployed = true;
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
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

        public void ReportByFullNameDataFount()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;
            FilteredStaff.ReportByFullName("ad");
            if(FilteredStaff.count == 3)
            {
                if (FilteredStaff.StaffList[0].StaffID != 9)
                {
                    OK = false;
                }
                if (FilteredStaff.CustomerList[1].StaffID != 10)
                {
                    OK = false;
                }
                if (FilteredStaff.CustomerList[2].StaffID != 11)
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
