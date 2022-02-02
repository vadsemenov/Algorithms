using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class StackList<T> : IStack <T>
    {
        private List<T> _stack = new List<T>();


        //Inserts an object at the top
        public void Push(T value)
        {
            _stack.Add(value);
        }

        //Removes and returns the object at the top
        public T Pop()
        {
            if (_stack.Count > 0)
            {
                var LastValue = _stack.Last();
                _stack.Remove(LastValue);
                return LastValue;
            }
            return default(T);
        }

        //Returns the object at the top, without removing it.
        public T Peek()
        {
            if (_stack.Count > 0) return _stack.Last();

            return default(T);
        }
    }
}