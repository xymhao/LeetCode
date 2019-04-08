using System;
using System.Collections.Generic;

namespace LeetCode
{
    public static class StringObject
    {
        public static int NumJewelsInStones(string J, string S)
        {
            int num = 0;
            for (var i = 0; i < S.Length; i++)
            {
                for (var j = 0; j < J.Length; j++)
                {
                    if (S[i] == J[j])
                    {
                        num++;
                    }
                }

            }
            return num;
        }

        public static int NumUniqueEmails(string[] emails)
        {
            List<string> ls = new List<string>();
            for (var i = 0; i < emails.Length; i++)
            {
                var emArr = emails[i].Split('@');
                var str1 = emArr[0].Replace(".", "").Split('+')[0];
                var email = string.Format($"{str1}{emArr[1]}");
                if (!ls.Contains(email))
                {
                    ls.Add(email);
                }
            }
            return ls.Count;
        }

        public static string ToLowerCase(string str)
        {
            var numAsc = 'a' - 'A';
            string strNew = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z' &&str[i] < 'a')
                {
                    strNew += Convert.ToChar(str[i] + numAsc).ToString();
                }
                else
                {
                    strNew += Convert.ToChar(str[i]).ToString();
                }
            }
            return strNew;
        }
    }
}
