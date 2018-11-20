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
    public class Valid_ParenthesesTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            Valid_Parentheses.IsValid("]");
            Assert.Fail();
        }
    }
}