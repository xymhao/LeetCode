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
    public class ThreeSumClosestTests
    {
        [TestMethod()]
        public void ThreeSumClosestsTest()
        {
            var result = ThreeSumClosest.ThreeSumClosests(new int[] { 1, 1, 1, 1 }, 4);
            Assert.AreEqual(result, 2);
        }

        [TestMethod()]
        public void LetterCombinationsTest()
        {
            var result = ThreeSumClosest.LetterCombinations("2345");
            Assert.Fail();
        }
    }
}