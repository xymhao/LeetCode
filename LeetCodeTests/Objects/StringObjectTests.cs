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
    public class StringObjectTests
    {
        [TestMethod()]
        public void ToLowerCaseTest()
        {
             StringObject.ToLowerCase("Hello");
            Assert.Fail();
        }
    }
}