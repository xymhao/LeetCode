using System;
using LeetCode.Model;

namespace LeetCodeTests
{
    public class IsomorphicString
    {
        private readonly string _one;
        private readonly IsomorphicChar _oneChar;

        public IsomorphicString(string one)
        {
            _one = one;
            _oneChar = new IsomorphicChar(one);
        }

        public bool Isomorphic(string another)
        {
            if (!_one.Length.Equals(another.Length))
            {
                return false;
            }
            var anotherChar = new IsomorphicChar(another);
            if (anotherChar.GetLength() != _oneChar.GetLength())
            {
                return false;
            }

            for (int i = 0; i < another.Length; i++)
            {
                if (anotherChar.GetIndex(another[i]) != _oneChar.GetIndex(_one[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}