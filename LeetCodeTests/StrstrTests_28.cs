using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests
{
    [TestClass]
    public class StrstrTests_28
    {
        [TestMethod]
        public void StrstrTests()
        {
            Solution solution = new Solution();
            
            //Assert.AreEqual(2, solution.StrStr("hello", "ll"));
            //Assert.AreEqual(3, solution.StrStr("heell", "ll"));
            //Assert.AreEqual(0, solution.StrStr("heell", "hee"));
            //Assert.AreEqual(-1, solution.StrStr("heell", "heet"));
            Assert.AreEqual(-1, solution.StrStr("", ""));

        }

    }

    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (needle.Length > haystack.Length)
            {
                return -1;
            }
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i].Equals(needle.ToCharArray().First()))
                {
                    if (haystack.Substring(i, needle.Length).Equals(needle))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}