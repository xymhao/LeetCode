namespace LeetCode.Objects
{
    public static class MaxArea
    {
        public static int MaxArea2(int[] height)
        {
            int max = int.MinValue;
            int left = 0, right = height.Length - 1;

            while (left < right && left >= 0 && right <= height.Length - 1)
            {
                var area = (right - left) * (height[right] > height[left] ? height[left] : height[right]);
                max = area > max ? area : max;
                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return max;
        }
    }
}
