using System;
using System.Collections.Generic;

namespace LeetCode
{
    public static class FourSum
    {
        public static IList<IList<int>> FourSum18(int[] nums, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length < 4)
                return result.ToArray();
            Array.Sort(nums);
            //QuickSort(nums,0, nums.Length-1);
            for (int first = 0; first < nums.Length -3; first++)
            {
                for (int second = first + 1; second < nums.Length - 2; second++)
                {
                    int low = second + 1;
                    int high = nums.Length - 1;
                    while (low < high)
                    {
                        int sum = nums[first] + nums[second] + nums[low] + nums[high];
                        if (sum == target)
                            result.Add(new int[] { nums[first], nums[second], nums[low], nums[high] });
                        if (sum <= target)
                        {
                            while (low + 1 < high && nums[low] == nums[low + 1])
                            { low++; };
                            low++;
                        }
                        if (sum > target)
                        {
                            while (low < high - 1 && nums[high] == nums[high - 1])
                            { high--; }
                            high--;
                        }
                    }
                    while (second + 1 < nums.Length - 2 && nums[second] == nums[second + 1]) { second++; }
                }
                while (first + 1 < nums.Length - 3 && nums[first] == nums[first + 1]) { first++; }
            }
            return result.ToArray();
        }

        public static void BubbleSort(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        var temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }

        public static void QuickSort(IList<int> numbers, int left, int right)
        {
            if (left < right)
            {
                int pivot = numbers[(left + right) / 2];
                int i = left - 1;
                int j = right + 1;
                while (true)
                {
                    while (numbers[++i] < pivot) ;
                    while (numbers[--j] > pivot) ;

                    if (i >= j)
                        break;
                    var temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }

                QuickSort(numbers, left, i - 1);
                QuickSort(numbers, j + 1, right);

            }
        }
    }
}
