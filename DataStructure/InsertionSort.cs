using System;

namespace DataStructure
{
    public class InsertionSort
    {
        public static void Sort(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                var value = nums[i];
                int j = i - 1;
                for (; j >= 0; j--)
                {
                    if (nums[j] > value)
                    {
                        nums[j + 1] = nums[j];
                    }
                    else
                    {
                        break;
                    }
                }

                nums[j + 1] = value;
            }
        }
    }
}