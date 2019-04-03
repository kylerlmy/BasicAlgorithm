using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Basic.Sort
{
    /// <summary>
    /// 选择排序 
    /// 分已排序区间和未排序区间
    /// </summary>
    public class SelectSort
    {

        public void Sort(int[] array)
        {
            var min = 0;
            var index = -1;
            for (int i = 0; i < array.Length / 2; i++)
            {
                min = array[i];
                index = -1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        index = j;
                    }
                }

                if (index != -1)
                {
                    array[index] = array[i];
                    array[i] = min;
                }
                  

            }
        }


        public void Sort2(int[] array)
        {
            var minIndex = 0;
            for (int i = 0; i < array.Length / 2; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    var minValue = array[minIndex];
                    array[minIndex] = array[i];
                    array[i] = minValue;
                }


            }
        }

    }
}
