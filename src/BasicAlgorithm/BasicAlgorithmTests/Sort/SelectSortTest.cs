using Algorithm.Basic.Sort;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BasicAlgorithmTests.Sort
{
    public class SelectSortTest
    {
        [Fact]
        public void SelectSortReturnSequentialValues()
        {
            var insertSort = new SelectSort();
            var sourceArray = new int[8] { 8, 7, 6, 5, 4, 3, 2, 1 };
            insertSort.Sort2(sourceArray);

            Assert.Equal(new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 }, sourceArray);
        }

        [Fact]
        public void SelectSortReturnrepeatValues()
        {
            var insertSort = new SelectSort();
            var sourceArray = new int[6] { 6, 5, 3, 3, 2, 1 };
            insertSort.Sort2(sourceArray);

            Assert.Equal(new int[6] { 1, 2, 3, 3, 5, 6 }, sourceArray);
        }

    }
}
