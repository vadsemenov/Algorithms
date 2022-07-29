namespace LinkedList;

public interface ISimpleLinkedList<T>
{
    SimpleLinkedListNode<T> First { get; set; }
    SimpleLinkedListNode<T> Last { get; set; }
    void AddBefore(T x);
    void AddAfter(T x);
    bool Remove(T x);
    bool Contains(T x);
    void Clear(T x);
}