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
    public class SortOBTests
    {
        [TestMethod()]
        public void BubbleSortTest()
        {
            SortOB.BubbleSort(new int[] { 5, 4, 3, 2, 1 });
            Assert.Fail();
        }

        [TestMethod()]
        public void SelectSortTest()
        {
            SortOB.SelectSort(new int[] { 5, 4, 3, 2, 1 });

            Assert.Fail();
        }

        [TestMethod()]
        public void InsertSortTest()
        {
            SortOB.InsertSort();

            Assert.Fail();
        }
    }
}