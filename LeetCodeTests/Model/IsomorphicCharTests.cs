using Microsoft.VisualStudio.TestTools.UnitTesting;         
using LeetCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Model.Tests
{
    [TestClass()]
    public class IsomorphicCharTests
    {
        [TestMethod()]
        public void Should_Return_Index_Char()
        {
            var isomorphicChar = new IsomorphicChar("abb");
            Assert.AreEqual(0, isomorphicChar.GetIndex('a'));
            Assert.AreEqual(1, isomorphicChar.GetIndex('b'));
        }

        [TestMethod]
        public void Should_Return_Length()
        {
            var isomorphicChar = new IsomorphicChar("abb");
            Assert.AreEqual(2, isomorphicChar.GetLength());
        }
    }
}