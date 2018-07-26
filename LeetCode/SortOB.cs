using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SortOB
    {
        /// <summary>
        ///  O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        public static void BubbleSort(int[] arr)
        {
            arr = new int[] { 5, 4, 3, 2, 1 };
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// O(n*(n-1）/2)
        /// </summary>
        /// <param name="arr"></param>
        public static void SelectSort(int[] arr)
        {
            int temp;
            int pos = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                pos = i;
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[pos])
                    {
                        pos = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[pos];
                arr[pos] = temp;
            }
        }

        /// <summary>
        /// O(n^2)
        /// </summary>
        public static void InsertSort()
        {
            int temp = 0;
            int[] arr = { 23, 44, 66, 76, 98, 11, 3, 9, 7 };
            var length = arr.Length;

            for (int i = 1; i < length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j] > arr[j - 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 1; i < length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j -1] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
