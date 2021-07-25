using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests
{
    [TestClass]
    public class AddBinaryTests
    {
        [TestMethod]
        public void Should_Result_11_add_1()
        {
            Assert.AreEqual("100", AddBinary("11", "1"));
            //"10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101"
            //"110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011"
            Assert.AreEqual("100",
                AddBinary(
                    "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101",
                    "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011"));
        }

        private string AddBinary(string a, string b)
        {
            var ans = new List<char>();

            int n = Math.Max(a.Length, b.Length);
            var carry = false;
            for (int i = 0; i < n; ++i)
            {
                var sum = 0;
                sum += i < a.Length ? (a.ToCharArray()[a.Length - 1 - i] - '0') : 0;
                sum += i < b.Length ? (b.ToCharArray()[b.Length - 1 - i] - '0') : 0;
                if (carry)
                {
                    sum++;
                }

                ans.Add((char) (sum % 2 + '0'));
                carry = sum >= 2;
            }

            if (carry)
            {
                ans.Add('1');
            }

            ans.Reverse();
            return new string(ans.ToArray());
        }

        /// <summary>
        /// 精度不够
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string AddBinary2(string a, string b)
        {
            var x = Convert.ToInt64(a, 2);
            var y = Convert.ToInt64(b, 2);
            ;

            while (y != 0)
            {
                var answer = x ^ y;
                var carry = (x & y) << 1;
                x = answer;
                y = carry;
            }

            return Convert.ToString(x, 2);
        }
    }
}