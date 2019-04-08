using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Objects.Tests
{
    [TestClass()]
    public class Median_of_Two_Sorted_ArraysTests
    {
        [TestMethod()]
        public void FindMedianSortedArraysTest()
        {
            Median_of_Two_Sorted_Arrays.FindMedianSortedArrays(new int[]{ 1,2}, new int[] { 3,4});
            Assert.Fail();
        }
    }
}