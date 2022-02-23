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
            //creat a new instance of the new class we want to create 
            clsStockList aStock = new clsStockList();
            //test to see that it exists 
            Assert.IsNotNull(aStock);


        }
        }
    }
