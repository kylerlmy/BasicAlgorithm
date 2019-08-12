
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Basic.Sort
{
    public class MergeSortTwice
    {
        public void MergeSortSub(int[] array, int p, int r)
        {
            //递归终止条件，不用再继续分解
            if (p >= r) return;

            // 取p到r之间的中间位置q,防止（p+r）的和超过int类型最大值
            var q = p + (r - p) / 2;//与（p+r）/2 的结果是相同的

            MergeSortSub(array, p, q);
            MergeSortSub(array, q + 1, r);

            Merge(array, p, q, r);
        }

        public void Merge(int[] array, int p, int q, int r)
        {
            var i = p;
            var j = q + 1;
            var k = 0;

            // 申请一个大小跟a[p...r]一样的临时数组
            var temp = new int[r - p + 1];
            while (i <= q && j <= r)
            {
                if (array[i] <= array[j])
                {
                    temp[k++] = array[i++];
                }
                else
                {
                    temp[k++] = array[j++];
                }
            }

            var start = i;
            var end = q;

            if (j <= r)
            {
                start = j;
                end = r;
            }

            while (start <= end)
            {
                temp[k++] = array[start++];
            }

            for (i = 0; i <= r - p; ++i)//注意等于号不要漏掉
            {
                array[p + i] = temp[i];
            }
        }
    }
}