namespace Stack
{
    public interface IStack <T>
    {
       T Push();
       T Pop();
       T Peek();
    }
}