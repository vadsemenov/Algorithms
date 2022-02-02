namespace Stack
{
    public interface IStack<T>
    {
        //Inserts an object at the top
        void Push(T value);

        //Removes and returns the object at the top
        T Pop();

        //Returns the object at the top, without removing it.
        T Peek();
    }
}