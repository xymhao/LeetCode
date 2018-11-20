using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Objects
{
    public class Regular_Expression_Matching
    {
        public bool IsMatch(string s, string p)
        {
            var sArr = s.ToCharArray();
            var pArr = p.ToCharArray();
            Stack<char> stack = new Stack<char>();

            if (p.Equals(".*") || p.Equals(s))
                return true;

            int i =0, j = 0;
            while (true)
            {
                if (i >= sArr.Length)
                    break;
                foreach (var c in sArr)
                {
                    var pChar = pArr[j];
                    stack.Push(pChar);
                    if (pChar.Equals('.'))
                        continue;
                    else
                    {
                        if (pChar.Equals(c))
                        {
                            i++;
                            j++;
                        }
                        else {
                            j++;
                        }

                    }
                }
            }
            return true;
        }
    }
}
