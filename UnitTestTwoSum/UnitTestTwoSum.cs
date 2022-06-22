using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SumTarget;

namespace UnitTestTwoSum
{
    [TestClass]
    public class UnitTestTwoSum
    {
        [TestMethod]
        public void TestTwoSum()
        {
            int[] array = { 3, 5, 4, 8 };
            int target = 9;
            int[2] solution1 = FindTarget(array, target);
            int[2] solution2 = { 1, 2 };
            Assert.AreEqual(solution1, solution2);
        }
    }
}
