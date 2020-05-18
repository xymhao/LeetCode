using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public class FindKthLargest
    {
        private static int[] array;

        public static int GetKthLargest(int[] nums, int k)
        {
            //根据快速排序，分区思想
            array = nums;
            return GetKthLargestRecursion(0, array.Length - 1, k);
        }

        private static int GetKthLargestRecursion(int p, int r, int k)
        {
            var q = Partition(p, r);

            if (q + 1 == k)
            {
                return array[q];
            }

            if (k > q + 1)
            {
                return GetKthLargestRecursion(q + 1, r, k);
            }

            return GetKthLargestRecursion(p, q - 1, k);

        }


        public static int Partition(int p, int r)
        {
            var pivot = array[r];
            int i = p;
            for (int j = p; j < r; j++)
            {
                if (array[j] > pivot)
                {
                    Swap(i, j);
                    i++;
                }
            }

            Swap(r, i);
            return i;
        }
        private static void Swap(int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
