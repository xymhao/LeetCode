using System;

namespace LeetCode
{
    public class MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            int pre = 0, maxAns = nums[0];
            foreach (int x in nums) {
                pre = Math.Max(pre + x, x);
                maxAns = Math.Max(maxAns, pre);
            }
            return maxAns;
        }
    }
}