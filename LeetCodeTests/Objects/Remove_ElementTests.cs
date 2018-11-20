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
    public class Remove_ElementTests
    {
        [TestMethod()]
        public void RemoveElementTest()
        {
            Remove_Element.RemoveElement(new int[] { 0,1,2,2,3,0,4,2}, 2);
            Assert.Fail();
        }
    }
}