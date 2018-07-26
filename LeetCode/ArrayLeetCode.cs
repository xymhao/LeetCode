using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class ArrayLeetCode
    {
        public static bool IsValidSudoku(char[,] board)
        {
            List<char> ls = new List<char>();
            List<char> ls2 = new List<char>();
            List<char> ls3 = new List<char>();

            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    if (!ls.Contains(board[i, j]))
                    {
                        if(board[i, j] != '.')
                            ls.Add(board[i, j]);//行
                    }
                    else
                    {
                        return false;
                    }
                    if (!ls2.Contains(board[j, i]))
                    {
                        if (board[j, i] != '.')
                            ls2.Add(board[j, i]);//列
                    }
                    else
                    {
                        return false;
                    }

                    if (i % 3 == 0 && j % 3 == 0)
                    {
                        for (var x = i; x < i + 3; x++)
                        {
                            for (var y = j; y < j + 3; y++)
                            {
                                if (!ls3.Contains(board[x, y]))
                                {
                                    if (board[x, y] != '.')
                                        ls3.Add(board[x, y]);

                                }
                                else
                                    return false;
                            }
                        }
                    }
                    ls3.Clear();
                }
                ls.Clear();
                ls2.Clear();
            }
            return true;
        }

        public static void Rotate(int[,] matrix)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var n = matrix.GetLength(0);
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    int y = n - i -1;
                    int x = j;
                    var key = string.Format("{0}-{1}", x, y);
                    if (!dict.TryGetValue(key, out int val))
                    {
                        dict.Add(key, matrix[x, y]);
                    }

                    if (!dict.TryGetValue(string.Format("{0}-{1}", i, j), out int value))
                    {
                        matrix[x, y] = matrix[i, j];
                    }
                    else
                    {
                        matrix[x, y] = value;
                    }
                }
            }
        }
    }
}
 