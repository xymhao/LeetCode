using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Objects
{
    public static class Search_in_Rotated_Sorted_Array
    {
        public static int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
                return -1;
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (target == nums[mid])
                    return mid;
                if (nums[mid] < nums[high])
                {
                    if (nums[mid] < target && target <= nums[high])
                        low = mid + 1;
                    else
                        high = mid - 1;
                }
                else if (nums[mid] > nums[high])
                {
                    if (nums[low] <= target && target < nums[mid])
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                else
                    high--;
            }
            return -1;
        }
    }
}
