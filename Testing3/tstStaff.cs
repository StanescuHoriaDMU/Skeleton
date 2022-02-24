using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void TestMethod1()

            {
                clsStaff AStaff = new clsStaff();

                Assert.IsNotNull(AStaff);
            }

     
    }
}
