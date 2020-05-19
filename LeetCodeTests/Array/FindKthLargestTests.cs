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
            int[] array = new int[] {3, 2, 1, 5, 6, 4}; var result = FindKthLargest.GetKthLargest(array, 2);
            Assert.AreEqual(5, result);

        }


        [TestMethod()]
        public void FindKthLargestTest2()
        {
            int[] array = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }; var result = FindKthLargest.GetKthLargest(array, 4);
            Assert.AreEqual(4, result);

        }

        [TestMethod()]
        public void FindKthLargestTest3()
        {
            int[] array = new int[] { 3,1,2,4 }; 
            var result = FindKthLargest.GetKthLargest(array, 2);
            Assert.AreEqual(3, result);

        }
    }

}