using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Basic.Sort
{
    /// <summary>
    /// 利用分治思想，将大问题分解位小的子问题，解决小问题，大问题也就解决了
    /// 
    /// 分治是一种解决问题的思想，递归是一种编程技巧
    /// </summary>
    public class MergeSort
    {


        public void Sort(int[] sourceArray, int capacity)
        {

        }

        private void ToMergeSort(int[] sourceArray, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex) return;

            var middleIndex = (startIndex + endIndex) / 2;

            var subArrayA = new int[middleIndex];
            var subArrayB = new int[endIndex - middleIndex];

            for (int i = 0; i < middleIndex; i++)
            {
                subArrayA[i] = sourceArray[i];
            }

            for (int i = middleIndex; i < endIndex; i++)
            {
                subArrayB[i] = sourceArray[i];
            }

            ToMergeSort(subArrayA, startIndex, middleIndex);
            ToMergeSort(subArrayB, middleIndex + 1, endIndex);

            Merge(sourceArray, subArrayA, subArrayB);

        }



        public void MergeSortItems(int[] array, int p, int q, int r)
        {
            int j = p;
            int i = q + 1;
            int k = 0;
            var temp = new int[r - p + 1];

            while (j <= q && i <= r)
            {
                if (array[i] <= array[j])
                    temp[k++] = array[i++];
                else
                    temp[k++] = array[j++];
            }

            int start = i;
            int end = q;

            if (j > i)
            {
                start = j;
                end = r;
            }


            while (start < end)
            {
                temp[k++] = array[start++];
            }


            for (int m = 0; m < array.Length; m++)
            {
                array[p + m] = temp[m];
            }

        }



        public void Merge(int[] sourceArray, int[] subArrayA, int[] subArrayB)
        {
            var i = 0;
            var j = 0;

            var lengthA = subArrayA.Length;
            var lengthB = subArrayB.Length;

            var length = 0;
            int[] array;
            if (lengthA > lengthB)
            {
                length = lengthB;
                array = subArrayA;
            }
            else
            {
                length = lengthA;
                array = subArrayB;
            }

            var index = 0;
            for (; index < length; index++)
            {
                if (subArrayA[i] <= subArrayB[j])
                {
                    sourceArray[index] = subArrayA[i];
                    i++;
                }
                else
                {
                    sourceArray[index] = subArrayB[j];
                    j++;
                }
            }

            var k = i > j ? i : j;
            for (; k < sourceArray.Length - index; index++, k++)
            {
                sourceArray[index] = array[k];
            }
        }


    }
}
