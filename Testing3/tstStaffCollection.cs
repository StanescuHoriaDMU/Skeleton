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
        public void StaffListOk()
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

        public void CountStaffOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 SomeCount = 0;
            AllStaff.Count = SomeCount;
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }


        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.FullName = "Tyler Ellis";
            TestStaff.EmailAddress = "tylerellis31@gmail.com";
            TestStaff.DOB = DateTime.Now.Date;
            TestStaff.UserName = "ellistyler123";
            TestStaff.IsEmployed = true;
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestStaff.FullName = "Tyler Ellis";
            TestStaff.EmailAddress = "tylerellis31@gmail.com";
            TestStaff.DOB = DateTime.Now.Date;
            TestStaff.UserName = "ellistyler123";
            TestStaff.IsEmployed = true;
            TestList.add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

    }
}
