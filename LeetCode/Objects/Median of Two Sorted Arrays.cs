using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Objects
{
    public static class Median_of_Two_Sorted_Arrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> ls = new List<int>();
            ls.AddRange(nums1);
            ls.AddRange(nums2);
            ls.Sort();
            double middle = 0d;
            if (ls.Count % 2 == 0)
            {
                var index = ls.Count / 2;
                middle = (ls[index] + ls[index - 1]) / 2.0;
            }
            else
            {
                middle = ls[ls.Count / 2];
            }
            return middle;
        }
    }
}
