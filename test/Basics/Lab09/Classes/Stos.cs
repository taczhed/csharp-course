using System;
using test.Basics.Lab09.Interfaces;

namespace test.Basics.Lab09.Classes
{
    public class Stos<T> : IStos<T>
    {
        private List<T> elements = new List<T>();

        public void Push(T value)
        {
            elements.Add(value);
        }

        public T Peek
        {
            get
            {
                if (IsEmpty)
                {
                    throw new StosEmptyException();
                }
                return elements[elements.Count - 1];
            }
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new StosEmptyException();
            }
            T value = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return value;
        }

        public int Count
        {
            get { return elements.Count; }
        }

        public bool IsEmpty
        {
            get { return elements.Count == 0; }
        }

        public void Clear()
        {
            elements.Clear();
        }

        public T[] ToArray()
        {
            return elements.ToArray();
        }
    }
}
