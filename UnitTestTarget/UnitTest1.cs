using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TwoSumTarget;

namespace UnitTestTarget
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTwoSumTarget()
        {
            TwoSumTarget tst = new TwoSumTarget();
            double res = tst.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }
    }
}
