using System.Runtime.Remoting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests
{
    [TestClass]
    public class LengthOfLastWordTests
    {
        [TestMethod]
        public void Should_Result()
        {
            var result = LengthOfLastWord("Hello World");
            Assert.AreEqual(5, result);
            
            result = LengthOfLastWord(" ");
            Assert.AreEqual(0, result);
        }
        
        public int LengthOfLastWord(string s) {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            char[] str = s.Trim().ToCharArray();
            int count = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    return count;
                }

                count++;
            }

            return count;
        }
    }
    
    
}