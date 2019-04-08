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
    public class Search_in_Rotated_Sorted_ArrayTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            var index = Search_in_Rotated_Sorted_Array.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
            Assert.AreEqual(index, 4);
        }
    }
}