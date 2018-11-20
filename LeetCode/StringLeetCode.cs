using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class StringLeetCode
    {
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            if (s.Length == 1)
                return 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (dict.TryGetValue(s[i], out int val))
                {
                    dict[s[i]] = val + 1;
                }
                else
                {
                    dict[s[i]] = 0;
                }
            }
            for (var i = 0; i < s.Length; i++)
            {
                if (dict.TryGetValue(s[i], out int val))
                {
                    if (val == 0)
                        return i;
                }
            }
            return -1;
        }

        public static bool IsPalindrome(string s = "A man, a plan, a canal: Panama")
        {
            Stack<char> stack = new Stack<char>();
            s = s.ToLower();
            foreach (var c in s)
            {
                if ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
                    stack.Push(c);
            }
            foreach (var c in s)
            {
                if (c >= 'a' && c <= 'z' || (c >= '0' && c <= '9'))
                {
                    if (!(c == stack.Pop()))
                        return false;
                }
            }
            return true;
        }

        public static void Convert(string str = "abcABC123")
        {
            string result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    result += str[i] + ('a' - 'A');
                }
                else if (str[i] >= 'a' && str[i] <= 'z')
                {
                    result += str[i] - ('a' - 'A');

                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    result += str[i].ToString();
                }
            }
        }

        public static int r()
        {
            Random random = new Random();
            var val = random.Next(10);
            return val;
        }

        public static int R(int x, int y)
        {
            var val = r();
            val = y - val % (y - x);
            return val;
        }
    }
}
