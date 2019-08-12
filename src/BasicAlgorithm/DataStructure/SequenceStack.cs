using System;

namespace DataStruct
{
    public class SequenceStack
    {
        private string[] _items;
        private int _count;
        private int _capacity;

        public SequenceStack(int capasity)
        {
            _items = new string[capasity];
            _capacity = capasity;
            _count = 0;
        }

        public bool Push(string item)
        {
            if (_count >= _capacity) return false;
            _items[_count] = item;
            _count++;

            return true;
        }

        public string Pop()
        {
            if (_count <= 0) return null;

            var result = _items[_count - 1];
            _count--;
            return result;
        }

    }
}
