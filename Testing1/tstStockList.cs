using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStockList
    {
        [TestMethod]
        public void InstanceOK(){
            clsStockList aStock = new clsStockList();
            Assert.IsNotNull(aStock);


        }
        }
    }
