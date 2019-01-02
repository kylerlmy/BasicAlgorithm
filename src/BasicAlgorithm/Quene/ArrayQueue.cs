using System;

namespace Quene
{
    public class ArrayQueue
    {
        private string[] items;

        private int arrayLength = 0;

        private int head = 0;
        private int tail = 0;

        public ArrayQueue()
        {

        }

        public ArrayQueue(int capacity):this()
        {
            items = new string[capacity];
            arrayLength = capacity;
        }

        public bool Enquenue(string item)
        {
            //如果队列已经满了,直接退出
            if (tail == arrayLength) return false;

            items[tail] = item;
            ++tail;

            return true;
        }

        public string Dequenue()
        {
            //如果队列为空，返回null
            if (head == tail) return null;

            var result = items[head];

            ++head;

            return result;
        }


    }
}
