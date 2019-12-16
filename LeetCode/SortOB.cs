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
                bool flag = true;
                for (var j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] <= arr[j + 1])
                    {
                        continue;
                    }
                    var temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                    flag = false;
                }
                if (flag)
                {
                    break;
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

        public static void QuickSort(int[] numbers, int left, int right)
        {
            if (left < right)
            {
                int middle = numbers[(left + right) / 2];
                int i = left - 1;
                int j = right + 1;
                while (true)
                {
                    while (numbers[++i] < middle) ;

                    while (numbers[--j] > middle) ;

                    if (i >= j)
                        break;

                    Swap(numbers, i, j);
                }

                QuickSort(numbers, left, i - 1);
                QuickSort(numbers, j + 1, right);
            }
        }


        private static void Swap(int[] numbers, int i, int j)
        {
            int number = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = number;
        }


        public static void YueQuickSort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int i = left - 1;
                int j = right + 1;
                var temp = nums[left];
                while (true)
                {
                    while (nums[++i] < temp) ;
                    while (nums[--j] > temp) ;
                    if (i >= j)
                        break;
                    Swap(nums, i, j);
                }
                YueQuickSort(nums, left, i-1);
                YueQuickSort(nums, j+1, right);
            }
        }


        /*
          父节点i的左子节点在位置 {\displaystyle (2i+1)} {\displaystyle (2i+1)};
          父节点i的右子节点在位置 {\displaystyle (2i+2)} {\displaystyle (2i+2)};
          子节点i的父节点在位置 {\displaystyle floor((i-1)/2)} {\displaystyle floor((i-1)/2)};

         大顶堆：arr[i] >= arr[2i+1] && arr[i] >= arr[2i+2]  

         小顶堆：arr[i] <= arr[2i+1] && arr[i] <= arr[2i+2]  
*/

        public static void HeapAdjust(List<int> list, int parent, int length)
        {
            int temp = list[parent];

            int child = 2 * parent + 1;

            while (child < length)
            {
                if (child + 1 < length && list[child] < list[child + 1])
                    child++;

                if (temp >= list[child])
                    break;

                list[parent] = list[child];

                parent = child;

                child = 2 * parent + 1;
            }

            list[parent] = temp;
        }

        public static List<int> HeapSort(List<int> list, int top)
        {
            List<int> topNode = new List<int>();

            for (int i = list.Count / 2 - 1; i >= 0; i--)
            {
                HeapAdjust(list, i, list.Count);
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                int temp = list[0];
                list[0] = list[i];
                list[i] = temp;

                topNode.Add(temp);

                HeapAdjust(list, 0, i);
            }
            return topNode;
        }
    }
}
