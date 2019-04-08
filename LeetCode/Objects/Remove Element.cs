namespace LeetCode.Objects
{
    public static class Remove_Element
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int length = 0;

            for (var i = 0; i < nums.Length - length; i++)
            {
                if (nums[i].Equals(val))
                {
                    int index = i;
                    for (var j = i + 1; j < nums.Length; j++)
                    {
                        while (j < nums.Length && nums[j] == val)
                        {
                            j++;
                            length++;
                        }
                        if (j >= nums.Length)
                            break;
                        nums[index] = nums[j];
                        index++;
                    }
                    length++;
                }
            }
            return nums.Length - length;
        }
    }
}
