using System;

namespace DataStruct
{
    public class CircularQueue
    {
        private string[] _items;
        private int _capacity;
        private int _head;
        private int _tail;


        public CircularQueue(int capasity)
        {
            _items = new string[capasity];
            _capacity = capasity;
            _head = 0;
            _tail = 0;
        }

        public bool EnQueue(string item)
        {
            if ((_tail + 1) % _capacity == _head)//队满，注意这个条件，只有在队满的时候才执行数据迁移
                return false;

            _items[_tail] = item;
            // _tail++;

            _tail = (_tail + 1) % _capacity;

            return true;
        }

        public string DeQueue()
        {
            if (_head == _tail) return null;//对空

            var result = _items[_head];
            _head--;
            return result;
        }
    }
}
