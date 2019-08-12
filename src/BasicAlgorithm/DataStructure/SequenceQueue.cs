using System;

namespace DataStruct
{
    public class SequenceQueue
    {
        private string[] _items;
        private int _capacity;
        private int _head;
        private int _tail;


        public SequenceQueue(int capasity)
        {
            _items = new string[capasity];
            _capacity = capasity;
            _head = 0;
            _tail = 0;
        }

        public bool EnQueue(string item)
        {
            //if (_tail == _capacity) return false;
            if (_tail == _capacity)//注意这个条件，只有在队满的时候才执行数据迁移
            {
                //tail==n&&head==0,表示整个队列都占满了
                if (_head == 0) return false;//注意这个条件

                for (int i = _head; i < _tail; i++)
                {
                    _items[i - _head] = _items[_head];
                }

                _tail = _tail - _head;
                _head = 0;
            }

            _items[_tail] = item;
            _tail++;

            return true;
        }

        public string DeQueue()
        {
            if (_head == _tail) return null;

            var result = _items[_head];
            _head--;
            return result;
        }
    }
}
