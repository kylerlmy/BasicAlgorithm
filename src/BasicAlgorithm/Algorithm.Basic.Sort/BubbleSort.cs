using System;

namespace Algorithm.Basic.Sort
{
    public class BubbleSort
    {
        public void Sort(int[] sourceArray)
        {
            var arrayLength = sourceArray.Length;
            if (arrayLength <= 1) return;

            for (int i = 0; i < arrayLength; i++)
            {
                //对于有序的数据，如果没有标志位耗时比较长
                var haveExchange = false;
                for (int j = 0; j < arrayLength-i-1; j++)
                {
                    if (sourceArray[j] > sourceArray[j+1])
                    {
                        var temp = sourceArray[j];
                        sourceArray[j] = sourceArray[j + 1];
                        sourceArray[j + 1] = temp;

                        haveExchange = true;//有数据交换
                    }
                }
                if (!haveExchange) break;//没有数据交换直接退出

            }
        }


        public void SortNoFlag(int[] sourceArray)
        {
            var arrayLength = sourceArray.Length;
            if (arrayLength <= 1) return;

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength - i - 1; j++)
                {
                    if (sourceArray[j] > sourceArray[j + 1])
                    {
                        var temp = sourceArray[j];
                        sourceArray[j] = sourceArray[j + 1];
                        sourceArray[j + 1] = temp;

                    }
                }

            }
        }
    }
}
