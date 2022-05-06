using System;
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
            clsDataConnection allStock = new ClassLibrary.clsDataCollection(); // for some reasom this is not recognising the clsStockCollection
            Assert.IsNotNull(allStock);

        }
        [TestMethod]
            public void StockListOK() //
            {
                clsStockList allStock = new clsStockList();
                List<clsStockList> TestList = new List<clsStockList>();
                clsStockList TestItem = new clsStockList();
                TestItem.VehicleId = 1;
                TestItem.DatePostWasAdded = Convert.ToDateTime("01/01/2016");
                TestItem.PriceTag = 12000;
                TestItem.Sold = false;
                TestItem.Vmodel = "BMW 1 - Series";
                TestItem.YOV = Convert.ToDateTime("01/01/2013");
                TestList.Add(TestItem);
                allStock.StockList = TestList;
                Assert.AreEqual(allStock.StockList, TestList);
            }

            [TestMethod]
            public void ThisStockOK() //
            {
                clsStockList allStock = new clsStockList();
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
        }
    }
}
