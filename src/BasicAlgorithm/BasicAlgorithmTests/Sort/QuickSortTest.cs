using Algorithm.Basic.Sort;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BasicAlgorithmTests.Sort
{
    public class QuickSortTest
    {
        private QueckSort _queckSort;
        public QuickSortTest()
        {
            _queckSort = new QueckSort();
        }

        [Fact]
        public void QueckSortReturnSequencedArray()
        {
            //Given
            var sourceArray = new int[] { 6, 5, 4, 3, 2, 1, 6 };
            //When
            _queckSort.Sort(sourceArray, sourceArray.Length);
            //Then
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 6 }, sourceArray);
        }
    }
}