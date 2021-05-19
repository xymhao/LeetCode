using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Stack
{
    /// <summary>
    /// 有效的括号匹配
    /// </summary>
    public class ValidParentheses
    {
        /*
         * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
         */

        public bool IsValid(string s)
        {
            if (s == null || s.Length % 2 == 1)
            {
                return false;
            }
            var stack = new Stack<char>();
            foreach (char c in s)
            {
                if (stack.Count == 0)
                {
                    stack.Push(c);
                    continue;
                }
                
                char leftP = stack.Peek();
                if (leftP == '(' && c == ')'
                    || leftP == '[' && c == ']'
                    || leftP == '{' && c == '}')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }
    }
}