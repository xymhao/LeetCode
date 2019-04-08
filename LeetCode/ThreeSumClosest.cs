using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ThreeSumClosest
    {
        public static IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }
            var first = GetStrArr(digits[0]);
            for (var i = 1; i < digits.Length; i++)
            {
                first = Combination(first, GetStrArr(digits[i]));
            }
            return first;
        }

        public static List<string> GetStrArr(char c)
        {
            var ls = new List<string>();
            switch (c)
            {
                case '2': ls = new List<string>() { "a", "b", "c" }; break;
                case '3': ls = new List<string>() { "d", "e", "f" }; break;
                case '4': ls = new List<string>() { "g", "h", "i" }; break;
                case '5': ls = new List<string>() { "j", "k", "l" }; break;
                case '6': ls = new List<string>() { "m", "n", "o" }; break;
                case '7': ls = new List<string>() { "p", "q", "r", "s" }; break;
                case '8': ls = new List<string>() { "t", "u", "v" }; break;
                case '9': ls = new List<string>() { "w", "x", "y", "z" }; break;
            }
            return ls;
        }

        public static List<string> Combination(List<string> ls1, List<string> ls2)
        {
            var ls = new List<string>();
            foreach(var s1 in ls1)
            {
                foreach (var s2 in ls2)
                {
                    ls.Add(s1 + s2);
                }
            }
            return ls;
        }




        public static int ThreeSumClosests(int[] nums, int target)
        {
            int result;
            if (nums.Length <= 3)
            {
                return nums.Sum();
            }
            result = nums[0] + nums[1] + nums[2];
            int dif = nums[0] + nums[1] + nums[2] - target;
            if (dif < 0)
            {
                dif = -dif;
            }
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    for (var k = j + 1; k < nums.Length; k++)
                    {
                        var x = nums[i] + nums[j] + nums[k] - target;
                        if (x == 0)
                            return target;
                        x = x < 0 ? -x : x;

                        if (x < dif)
                        {
                            dif = x;
                            result = nums[i] + nums[j] + nums[k];
                        }
                    }
                }
            }
            return result;
        }

        public static int[] Sort(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
