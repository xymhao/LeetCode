using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 8;
            double b = 5;
            double c = 6;

            var xx = (4 ^ 2) ^ 2;
            var x = Convert.ToInt32(a / b);
            var x2 = Convert.ToInt32(a / c);
            int[] nums = new int[] { -1,0,0,0,0,3,3};
            //RemoveDuplicates(nums);
            MaxProfit(new int[] {1,2,3,4,5});
            Console.WriteLine(a / b);
            Rotate(new int[] { 1,2,3,4,5,6,7},3);
            SingleNumber(new int[] { 4,1,2,1,2});
            Console.Read();
        }
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (var i = 0; i < nums1.Length; i++)
            {
                for (var j = 0; j < nums2.Length; j++)
                {

                }
            }
        }


        public static int RemoveDuplicates(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.TryGetValue(nums[i], out int val))
                {
                    dict[nums[i]] = val;
                }
            }
            int j = 0;
            foreach (var d in dict)
            {
                nums[j] = d.Key;
                j++;
            }
            return dict.Count;
        }

        public static int  MaxProfit(int[] prices)
        {
            int money = 0;
            for (var i = 0; i < prices.Length -1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    money = money + prices[i + 1] - prices[i];
                }
            }
            return money;
        }
        public static void Rotate(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] backupNums = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                var index = i + k >= nums.Length ? (i + k) % nums.Length : i + k;
                backupNums[index] = nums[i];
            }

            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] = backupNums[i];
            }
        }

        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.TryGetValue(nums[i], out int val))
                {
                    return true;
                }
                else
                {
                    dict[nums[i]] = 0;
                }
            }
            return false;
        }

        public static int SingleNumber(int[] nums)
        {
            int res = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                res ^= nums[i];
            }
            return res;
        }

    }
}
