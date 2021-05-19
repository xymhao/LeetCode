using LeetCode.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Stack
{
    [TestClass]
    public class ValidParenthesesTests
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow("()", true)]
        [DataRow("()[]{}", true)]
        [DataRow("{[]}", true)]
        [DataRow("(]", false)]
        [DataRow("([)]", false)]
        [DataRow("]", false)]
        public void Should_IsValid(string s, bool expect)
        {
            var result = new ValidParentheses().IsValid(s);
            
            Assert.AreEqual(expect, result);
        }
    }
}