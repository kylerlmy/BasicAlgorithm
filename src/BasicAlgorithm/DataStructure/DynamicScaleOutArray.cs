using System;

namespace DataStruct
{
    public class DynamicScaleOutArray
    {
        private int[] _dataArray;
        private int _currentIndex;//新插入元素的索引


        public DynamicScaleOutArray()
        {

        }

        public DynamicScaleOutArray(int capacity) : this()
        {
            _dataArray = new int[capacity];
        }


        public int GetElement(int index)
        {
            if (index < 0 || index >= _currentIndex) throw new ArgumentException("index");

            return _dataArray[index];
        }

        public void AddElement(int value, int index)
        {
            if (_currentIndex >= _dataArray.Length)
                Resize(2 * _dataArray.Length);


            for (int i = _currentIndex; i > index; i--)
            {
                _dataArray[i + 1] = _dataArray[i];
            }

            _dataArray[index] = value;
        }

        public void AddElement(int value)
        {
            AddElement(value, _currentIndex);
            _currentIndex++;
        }


        private void Resize(int capacity)
        {
            if (capacity <= _dataArray.Length) return;
            var newArray = new int[capacity];

            for (int i = 0; i < _currentIndex; i++)
            {
                newArray[i] = _dataArray[i];
            }

            _dataArray = newArray;
        }


        public bool RemoveElementByIndex(int index)
        {
            if (_dataArray.Length <= 0) return false;

            for (int i = index + 1; i < _dataArray.Length; i++)
            {
                _dataArray[i - 1] = _dataArray[i];
            }

            return true;
        }

        private bool RemoveElement(int data)
        {
            //不可行，当一个数组中出现多个重复值，将导致多个元素被删除，删除数组元素还是需要通过索引删除
            if (_dataArray.Length <= 0) return false;

            var isStartMove = false;
            for (int i = 0; i < _dataArray.Length; i++)
            {
                if (_dataArray[i] == data)
                {
                    isStartMove = true;
                }
                if (isStartMove)
                {
                    if (i + 1 < _dataArray.Length)
                        _dataArray[i] = _dataArray[i + 1];
                }
            }

            return true;
        }

    }
}
