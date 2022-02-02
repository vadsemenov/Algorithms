namespace Queue
{
    public interface IQueue<T>
    {
        //Inserts an object at the down
        void Enqueue(T value);

        //Removes and returns the object at the top
        T Dequeue();

        //Returns the object at the top, without removing it.
        T Peek();
    }
}