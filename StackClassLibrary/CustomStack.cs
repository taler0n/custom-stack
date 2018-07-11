using System;
using System.Text;
using System.Collections.Generic;

namespace StackClassLibrary
{
    public class CustomStack<T>
    {
        class Node
        {
            public T _value;
            public Node _next;
            public Node(T value)
            {
                _value = value;
            }
        }

        Node _top;
        public int Count { get; private set; }
        public CustomStack()
        {
            _top = null;
            Count = 0;
        }
        public void Push(T value)
        {
            var newNode = new Node(value);
            newNode._next = _top;
            _top = newNode;
            Count++;
        }
        public T Peek()
        {
            if (_top != null)
                return _top._value;
            throw new InvalidOperationException("Stack is empty");
        }
        public T Pop()
        {
            if (_top != null)
            {
                T tmp = _top._value;
                _top = _top._next;
                Count--;
                return tmp;
            }
            throw new InvalidOperationException("Stack is empty");
        }
        public void Clear()
        {
            _top = null;
            Count = 0;
        }
        public bool Contains(T value)
        {
            bool found = false;
            var tmpNode = _top;
            while (tmpNode != null)
            {
                if (tmpNode._value.Equals(value))
                {
                    found = true;
                    break;
                }
                tmpNode = tmpNode._next;
            }
            return found;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            var tmpNode = _top;
            while (tmpNode != null)
            {
                sb.AppendFormat("{0} ", tmpNode._value);
                tmpNode = tmpNode._next;
            }
            return sb.ToString();
        }
        public T[] ToArray()
        {
            if (Count > 0)
            {
                T[] array = new T[Count];
                var tmpNode = _top;
                for (int i = 0; i < Count; i++)
                {
                    array[i] = tmpNode._value;
                    tmpNode = tmpNode._next;
                }
                return array;
            }
            throw new InvalidOperationException("Stack is empty");
        }
    }
}
