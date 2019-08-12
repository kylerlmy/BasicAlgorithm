using Algorithm.Basic.Sort;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BasicAlgorithmTests.Sort
{
    public class MergeSortTest
    {
        private MergeSort _mergeSort;
        private MergeSortTwice _mergeSortTwice;
        private MergeSortThird _mergeSortThird;
        public MergeSortTest()
        {
            _mergeSort = new MergeSort();
            _mergeSortTwice = new MergeSortTwice();
            _mergeSortThird = new MergeSortThird();
        }

        [Fact]
        public void Merge_UnOrderedArray_ReturnSequentialArray()
        {
            var arrayA = new int[] { 1, 3, 5 };
            var arrayB = new int[] { 2, 4, 6 };
            var sourceArray = new int[] { 0, 0, 0, 0, 0, 0 };

            _mergeSort.Merge(sourceArray, arrayA, arrayB);

            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6 }, sourceArray);

        }

        [Fact]
        public void MergeSortItems_UnOrderedArray_ReturnSequentialArray()
        {
            var sourceArray = new int[] { 6, 5, 4, 3, 2, 1 };

            //    _mergeSort.MergeSortItems(sourceArray, 0, 3, 5);
            _mergeSortTwice.MergeSortSub(sourceArray, 0, sourceArray.Length - 1);
            // _mergeSortThird.mergeSortInternally(sourceArray, 0, sourceArray.Length - 1);

            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6 }, sourceArray);

        }

    }
}
