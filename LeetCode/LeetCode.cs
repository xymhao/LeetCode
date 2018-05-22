using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class LeetCode
    {


        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> ls = new List<IList<int>>();

            if (nums.Length < 3)
            {
                return ls;
            }
            nums = Sort(nums);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    var index = Search(nums, j + 1, nums.Length - 1, 0 - (nums[i] + nums[j]));
                    if (index != -1)
                    {
                        if (!dict.TryGetValue(nums[i].ToString() + nums[j].ToString(), out int val))
                        {
                            dict.Add(nums[i].ToString() + nums[j].ToString(), 0);
                            ls.Add(new int[] { nums[i], nums[j], nums[index] });
                        }
                    }
                }
            }
            return ls;
        }



        public static int Search(int[] arr, int left, int right, int key)
        {
            while (left <= right)
            {
                int mid = left + ((right - left) >> 1);
                if (arr[mid] == key)
                    return mid;
                else if (arr[mid] > key)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return -1;
        }

        public static int[] Sort(int[] arr)
        {
            int[] ls = new int[] { };
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length -1 -i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            for (var i = 0; i < arr.Length -1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    int val = arr[i];
                    ls = Push(ls, val);
                    ls = Push(ls, val);
                    int j = i + 2;
                    if (j < arr.Length && val == arr[j] && val == 0)
                        ls = Push(ls, 0);
                    while (j < arr.Length && arr[j] == val)
                    {
                        j++;
                    }
                    i = j -1;
                }
                else
                {
                    ls = Push(ls, arr[i]);
                }
            }
            if (ls.Length < arr.Length)
            {
                ls = Push(ls, arr[arr.Length - 1]);
            }
            return ls;
        }

        public static int[] Push(int[] arr, int val)
        {
            int[] ls = new int[arr.Length + 1];
            for (var i = 0; i < arr.Length; i++)
            {
                ls[i] = arr[i];
            }
            ls[arr.Length] = val;
            return ls;
        }
    }
}
