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
                for (int i = 0; i < array.Length - 1; i++)
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
        /// 快速排序
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

                array[k+1] = value;
            }

        }

        public static void SelectSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var min = i;
                for (int j = i+1; j < array.Length; j++)
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
    }
}
