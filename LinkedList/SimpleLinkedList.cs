namespace LinkedList;

public class SimpleLinkedList<T> : ISimpleLinkedList<T>
{
    public SimpleLinkedListNode<T> First { get; set; }
    public SimpleLinkedListNode<T> Last { get; set; }

    public void AddBefore(T x)
    {
        throw new NotImplementedException();
    }

    public void AddAfter(T x)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T x)
    {
        throw new NotImplementedException();
    }

    public bool Contains(T x)
    {
        throw new NotImplementedException();
    }

    public void Clear(T x)
    {
        throw new NotImplementedException();
    }

    private SimpleLinkedListNode<T> Find(T? x)
    {
        var currentNode = First;
        while (currentNode != null)
        {
            
            if (currentNode.Value.Equals(x))
                return currentNode;
        }

        return null;
    }
}