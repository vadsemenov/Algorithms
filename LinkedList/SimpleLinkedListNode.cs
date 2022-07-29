namespace LinkedList;

public class SimpleLinkedListNode<T>
{
    public T? Value { get; set; }
    public LinkedListNode<T> next;
    public LinkedListNode<T> previous;
}