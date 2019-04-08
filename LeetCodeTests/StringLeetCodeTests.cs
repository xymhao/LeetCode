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
    public class StringLeetCodeTests
    {
        [TestMethod()]
        public void FirstUniqCharTest()
        {
            var x = StringLeetCode.FirstUniqChar("dddccdbba");
            Assert.Fail();
        }

        [TestMethod()]
        public void ConvertTest()
        {
            StringLeetCode.Convert();
            Assert.Fail();
        }

        [TestMethod()]
        public void RTest()
        {
            StringLeetCode.R(1,2);
            Assert.Fail();
        }
    }
}