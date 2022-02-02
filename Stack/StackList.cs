using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class StackList<T> : IStack <T>
    {
        private List<T> _stack = new List<T>();


        public T Push()
        {
            
        }

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

        public T Peek()
        {
            if (_stack.Count > 0) return _stack.Last();

            return default(T);
        }
    }
}