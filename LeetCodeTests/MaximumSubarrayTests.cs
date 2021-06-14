using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests
{
    [TestClass]
    public class MaximumSubarrayTests
    {
        [TestMethod]
        public void Should_Result_6()
        {
            var result = MaximumSubarray.MaxSubArray(new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4});
            Assert.AreEqual(6, result);
        }
    }
}