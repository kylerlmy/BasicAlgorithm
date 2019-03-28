using Algorithm.Basic.Sort;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BasicAlgorithmTests.Sort
{
    public class BubbleSortTest
    {

        [Fact]
        public void BubbleSortReturnSequentialValues()
        {

            var bubbleSort = new BubbleSort();

            var sourceArray = new int[6] { 6, 5, 4, 3, 2, 1 };
            bubbleSort.Sort(sourceArray);

            Assert.Equal(sourceArray, new int[6] { 1, 2, 3, 4, 5, 6 });

        }

        [Fact]
        public void TenThousandsItemBubleSortSpendTime()
        {

            var bubbleSort = new BubbleSort();
            var sourceArray = GetSequentialArray(); //GetRandomArray();
            bubbleSort.Sort(sourceArray);

            Assert.Equal(10000, sourceArray.Length);
        }
        [Fact]
        public void TenThousandsItemBubbleNoFlagSortSpendTime()
        {
            var bubbleSort = new BubbleSort();

            var sourceArray = GetSequentialArray(); //GetRandomArray();

            bubbleSort.SortNoFlag(sourceArray);

            Assert.Equal(10000, sourceArray.Length);
        }


        private int[] GetSequentialArray()
        {
            var array = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                array[i] = i + 1;
            }

            return array;

        }


        private int[] GetRandomArray()
        {
            var sourceList = new List<int>();

            var random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                var value = random.Next(0, 1000);
                sourceList.Add(value);
            }

            return sourceList.ToArray();
        }
        


    }
}
