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

        [TestMethod()]
        public void SortTest()
        {
            var arr = new int[] { 5, 4, 3, 20, 32, 110, 85, 6, 1, 2, 5, 2, 1, 6, 7, 8, 9, 10 };

            Assert.Fail();
        }

        [TestMethod()]
        public void HeapSortTest()
        {
            var ls = SortOB.HeapSort(new List<int>() { 5, 4, 3, 20, 32, 110, 85, 6, 1, 2, 5, 2, 1, 6, 7, 8, 9, 10 }, 0);
            Assert.Fail();
        }

        [TestMethod()]
        public void YueQueickSelectTest()
        {
            var arr = new int[] { 5, 4, 3, 20, 32, 110, 85, 6, 1, 2, 5, 2, 1, 6, 7, 8, 9, 10 };
            SortOB.YueQuickSort(arr, 0, arr.Length - 1);

            Assert.Fail();
        }
    }
}