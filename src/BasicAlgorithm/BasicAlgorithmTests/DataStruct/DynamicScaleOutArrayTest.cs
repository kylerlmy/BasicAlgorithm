using DataStruct;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BasicAlgorithmTests.DataStruct
{
    public class DynamicScaleOutArrayTest:IDisposable
    {
        DynamicScaleOutArray _array;

        public DynamicScaleOutArrayTest()
        {
            _array = new DynamicScaleOutArray(10);
        }

        [Theory]
        [InlineData(1)]
        public void Setup(int a)
        {
            Assert.True(a == 1);
        }

        [Fact]
        public void AddElementSuccess()
        {
            for (int i = 1; i <= 10; i++)
            {
                _array.AddElement(i);
            }

            Assert.Equal(1, _array.GetElement(0));
            Assert.Equal(5, _array.GetElement(4));
            Assert.Equal(10, _array.GetElement(9));
        }

        [Fact]
        public void RemoveElementSuccess()
        {
            for (int i = 1; i <= 10; i++)
            {
                _array.AddElement(i);
            }

            _array.RemoveElementByIndex(2);

            Assert.Equal(2, _array.GetElement(0));
        }

        [Fact]
        public void AddSpecifiledElementSuccess()
        {
            for (int i = 1; i <= 10; i++)
            {
                _array.AddElement(i);
            }

            _array.AddElement(11, 2);


            Assert.True(_array.GetElement(2) == 11);
            Assert.True(_array.GetElement(0) == 1);
            Assert.True(_array.GetElement(9) == 9);
        }


        public void Dispose()
        {
            _array = null;
        }
    }
}
