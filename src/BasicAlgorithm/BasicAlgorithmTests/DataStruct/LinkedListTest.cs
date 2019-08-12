using DataStruct;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BasicAlgorithmTests.DataStruct
{
    public class LinkedListTest
    {

        private LinkedList _linkedList;
        public LinkedListTest()
        {
            _linkedList = new LinkedList();
        }

        [Theory]
        [InlineData(1)]
        public void Setup(int a)
        {
            Assert.True(a == 1);
        }

        [Fact]
        public void AddNodeTrue()
        {
            //Given
            _linkedList.AddNode(new LinkedList.Node(85));
            _linkedList.AddNode(new LinkedList.Node(15));
            _linkedList.AddNode(new LinkedList.Node(4));
            _linkedList.AddNode(new LinkedList.Node(20));
            //When
            Assert.Equal("85 15 4 20", _linkedList.GetLinked());
            //Then
        }

        [Fact]
        public void ReverseLinked()
        {
            _linkedList.AddNode(new LinkedList.Node(85));
            _linkedList.AddNode(new LinkedList.Node(15));
            _linkedList.AddNode(new LinkedList.Node(4));
            _linkedList.AddNode(new LinkedList.Node(20));
            //Given
            _linkedList.Reverse();
            //When
            Assert.Equal("20 4 15 85", _linkedList.GetLinked());
            //Then
        }

        [Fact]
        public void GetMiddlePointReturned()
        {
            //Given
            _linkedList.AddNode(new LinkedList.Node(85));
            _linkedList.AddNode(new LinkedList.Node(15));
            _linkedList.AddNode(new LinkedList.Node(4));
            _linkedList.AddNode(new LinkedList.Node(20));
            _linkedList.AddNode(new LinkedList.Node(16));
            //When
            var node = _linkedList.GetMiddlePoint();
            //Then

            Assert.Equal(4, node.Data);
        }

    }
}
