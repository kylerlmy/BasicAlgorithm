using Quene;
using System;
using Xunit;

namespace BasicAlgorithmTests
{
    public class QueneTests
    {
        [Fact]
        public void EnquenueTest()
        {
            var arrayQuene = new ArrayQueue(2);

            Assert.Null(arrayQuene.Dequenue());

            arrayQuene.Enquenue("one");
            arrayQuene.Enquenue("two");

            Assert.False(arrayQuene.Enquenue("three"));

            Assert.Equal("one", arrayQuene.Dequenue());
            Assert.Equal("two", arrayQuene.Dequenue());
            
        }
    }
}
