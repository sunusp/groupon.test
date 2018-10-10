using System.Linq;

namespace TechnicalTests.Stack
{
    public class Stack<T> : IStack<T>
    {
        private T[] _elements;
        private int topItem;
        private readonly int _maxSize;
        public Stack(int maxSize)
        {
            _elements = new T[maxSize];
            _maxSize = maxSize;
            topItem = -1;
        }

        public bool Push(T item)
        {
            bool isSuccess = true;

            if (topItem == _maxSize - 1)
            {
                isSuccess = false;
            }
            else
            {
                _elements[++topItem] = item;
            }

            return isSuccess;
        }

        public T Pop()
        {
            T popedItem;
            if (topItem == -1)
            {
                popedItem = default(T);
            }
            else
            {
                popedItem = _elements[topItem--];
                _elements[++topItem] = default(T);

            }
            return popedItem;
        }

        public T Peek()
        {
            if (_elements.Length > 0)
            {
                return _elements[_maxSize - 1];
            }

            return default(T);
        }

        public void Clear()
        {
            _elements = new T[0];
        }

        public bool Contains(T item)
        {
            return _elements.Contains(item);
        }

        public int Count()
        {
            return _elements.Length;
        }
    }
}
