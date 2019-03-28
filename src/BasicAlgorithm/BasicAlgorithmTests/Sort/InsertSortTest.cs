using Algorithm.Basic.Sort;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BasicAlgorithmTests.Sort
{
    public class InsertSortTest
    {
        [Fact]
        public void InsertSortReturnSequentialValues()
        {
            var insertSort =new InsertSort();
            var sourceArray = new int[6] { 6, 5, 4, 3, 2, 1 };
            insertSort.Sort(sourceArray);

            Assert.Equal(sourceArray, new int[6] { 1, 2, 3, 4, 5, 6 });
        }

    }
}
