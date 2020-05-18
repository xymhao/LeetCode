using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array.Tests
{
    [TestClass()]
    public class FindKthLargestTests
    {
        [TestMethod()]
        public void FindKthLargestTest()
        {
            int[] array = new int[] {3, 2, 1, 5, 6, 4};
            var result = FindKthLargest.GetKthLargest(array, 2);
            Assert.AreEqual(5, result);

        }
    }
}