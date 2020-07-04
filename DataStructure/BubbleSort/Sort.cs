using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.BubbleSort
{
    public class Sort
    {
        public static int[] BubbleSort(int[] array)
        {
            //冒泡排序需要循环array.length次
            for (int j = 0; j < array.Length; j++)
            {
                bool flag = false;
                //从0开始，如果i+1 > i， 则交换位置
                for (int i = 0; i < array.Length - 1 - j; i++)
                {
                    var temp = array[i];
                    if (temp > array[i + 1])
                    {
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        flag = true;
                    }
                }

                if (flag == false)
                {
                    break;
                }
            }
            return array;
        }

        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="array"></param>
        public static void InsertionSort(int[] array)
        {
            if (array.Length == 1)
            {
                return;
            }

            for (int i = 1; i < array.Length; ++i)
            {
                int value = array[i];
                int k = i - 1;
                for (; k >= 0; --k)
                {
                    //当前值小于array[k], 插入
                    if (value < array[k])
                    {
                        //后移
                        array[k + 1] = array[k];
                    }
                    else
                    {
                        break;
                    }
                }

                array[k + 1] = value;
            }

        }

        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="array"></param>
        public static void SelectSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }

                if (min == i) continue;

                var temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }

        /// <summary>
        /// 归并排序
        /// </summary>
        /// <param name="array"></param>
        public static void MergeSor(int[] array)
        {
            //todo 将数据分解
            DecompositionArray(array, 0, array.Length - 1);
        }

        private static void DecompositionArray(int[] array, int startIndex, int endIndex)
        {
            //终止条件
            if (startIndex >= endIndex)
            {
                return;
            }
            //取中间数
            var mid = (startIndex + endIndex) / 2;
            DecompositionArray(array, startIndex, mid);
            DecompositionArray(array, mid + 1, endIndex);

            Merge(array, startIndex, mid, endIndex);
        }

        private static void Merge(int[] array, in int startIndex, in int midIndex, in int endIndex)
        {
            var star = startIndex;
            var mid = midIndex + 1;
            var k = 0;
            var temp = new int[endIndex - startIndex + 1];
            while (star <= midIndex && mid <= endIndex)
            {
                if (array[star] < array[mid])
                {
                    temp[k++] = array[star++];
                }
                else
                {
                    temp[k++] = array[mid++];
                }
            }

            int oStar;
            int oEnd;
            if (star <= midIndex)
            {
                oStar = star;
                oEnd = midIndex;
            }
            else
            {
                oStar = mid;
                oEnd = endIndex;
            }

            while (oStar <= oEnd)
            {
                temp[k++] = array[oStar++];
            }

            for (int i = 0; i <= endIndex - startIndex; i++)
            {
                array[startIndex + i] = temp[i];
            }
        }

        public static void QuickSort(int[] array)
        {
            QuickSortRecursive(array, 0, array.Length - 1);
        }

        private static void QuickSortRecursive(int[] array, int p, int r)
        {
            if (p >= r)
            {
                return;
            }

            var q = Partition(array, p, r);
            QuickSortRecursive(array, p, q - 1);
            QuickSortRecursive(array, q + 1, r);
        }

        public static int Partition(int[] array, int p, int r)
        {
            //todo 设置pivot分区点，根据分区点分区
            //todo  分区1 ： p 到 i-1， 小于pivot
            //todo  分区2 ： i 到 r， 大于pivot
            var pivot = array[r];
            int i = p;
            for (int j = p; j < r; j++)
            {
                if (array[j] < pivot)
                {
                    Swap(array, i, j);
                    i++;
                }
            }

            Swap(array, r, i);
            return i;
        }

        private static void Swap(int[] array, in int i, in int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
