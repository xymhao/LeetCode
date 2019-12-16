using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Model;
using LeetCodeTests;

namespace LeetCode
{
    public class IsIsomorphicString
    {
        public bool IsIsomorphic(string s, string t)
        {
            var str = new IsomorphicString(s);
            return str.Isomorphic(t);
        }
    }
}
