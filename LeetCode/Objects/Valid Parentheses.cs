using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Objects
{
    public static class Valid_Parentheses
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            var charArr = s.ToCharArray();
            foreach (var c in charArr)
            {
                if (c.Equals('(') || c.Equals('{') || c.Equals('['))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;
                    var varChar = stack.Pop();
                    bool result = true;
                    switch (c)
                    {
                        case ')': result = varChar == '('; break;
                        case '}': result = varChar == '{'; break;
                        case ']': result = varChar == '['; break;
                    }
                    if (!result)
                        return false;
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
    }
}
