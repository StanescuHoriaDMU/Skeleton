﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff AStaff = new clsStaff();

            Assert.IsNotNull(AStaff);
        }


        
    }
}
