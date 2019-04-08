using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class FourSumTests
    {
        [TestMethod()]
        public void FourSum18Test()
        {
            var ls = FourSum.FourSum18(new int[] { 1, 0, -1, 0, -2, 2 }, 0);
            Assert.Fail();
        }
    }
}