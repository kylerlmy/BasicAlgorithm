using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Basic.Sort
{
    public class InsertSort
    {
        public void Sort(int[] sourceArray)
        {
            var arrayLength = sourceArray.Length;

            if (arrayLength <= 1) return;


            for (int i = 1; i < arrayLength; i++)
            {

                var value = sourceArray[i];//暂存当前值，以便腾出空间，进行数据移动

                var j = i - 1;//j变量的声明放到for循环中，结果就不一样啦

                for (; j >= 0; --j)
                {
                    if (sourceArray[j] > value)
                        sourceArray[j + 1] = sourceArray[j];//把值放到上一步腾出的空间，这样就腾出新的空间
                    else
                        break;
                }

                sourceArray[j + 1] = value;//此时j=-1

            }


        }


    }
}
