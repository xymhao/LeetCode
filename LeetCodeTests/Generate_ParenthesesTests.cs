using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests
{
    [TestClass]
    public class GenerateParenthesesTests
    {
        [TestMethod]
        public void Should_Return_5_When_Input_3()
        {
            GenerateParentheses tool = new GenerateParentheses();
            List<string> ls = tool.GenerateParenthesis(3);
            Assert.AreEqual(5, ls.Count);
        }
    }

    public class GenerateParentheses
    {
        public List<string> GenerateParenthesis(int num)
        {
            List<string> parentheses = new List<string>();
            Generate(parentheses, "", 0, 0, num);
            return parentheses;
        }

        public void Generate(IList<string> parentheses, string ans, int count1, int count2, int num)
        {
            if (ans.Length == num * 2)
            {
                parentheses.Add(ans);
                return;
            }

            if (count1 < num)
            {
                Generate(parentheses, ans + "(", count1+1, count2, num);
            }

            if (count2 < count1)
            {
                Generate(parentheses, ans + ")", count1, count2 + 1, num);
            }
        }
    }
}
