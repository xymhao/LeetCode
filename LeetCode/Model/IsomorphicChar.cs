using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Model
{
    public class IsomorphicChar
    {
        private readonly Dictionary<char, int> _chars;

        public IsomorphicChar(string value)
        {
            _chars = new Dictionary<char, int>();
            int i = 0;
            foreach (var c in value.ToCharArray())
            {
                if (!_chars.TryGetValue(c, out int _))
                {
                    _chars.Add(c, i++);
                }
            }
        }


        public int GetIndex(char c)
        {
            return _chars[c];
        }

        public int GetLength()
        {
            return _chars.Count;
        }
    }
}
