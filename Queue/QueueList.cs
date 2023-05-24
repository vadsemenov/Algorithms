using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    public class QueueList<T> : IQueue<T>
    {
        private List<T> _queue = new List<T>();


        //Inserts an object at the down
        public void Enqueue(T value)
        {
            _queue.Insert(0,value);
        }

        //Removes and returns the object at the top
        public T Dequeue()
        {
            if (_queue.Count > 0)
            {
                var LastValue = _queue.Last();
                _queue.Remove(LastValue);
                return LastValue;
            }
            return default(T);
        }

        //Returns the object at the top, without removing it.
        public T Peek()
        {
            if (_queue.Count > 0) return _queue.Last();

            return default(T);
        }
    }
}