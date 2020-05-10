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


    }
}
