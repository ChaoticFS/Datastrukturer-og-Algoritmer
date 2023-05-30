namespace datastructure;

public class DoublyLinkedList
{
    internal DblNode? head;
    internal DblNode? tail;

    public DoublyLinkedList(int value)
    {
        head = new DblNode(value, null, null);
        tail = head;
    }

    public void AddFirst(int value)
    {
        DblNode newHead = new DblNode(value, head, null);
        head.prev = newHead;
        head = newHead;
    }

    public void AddLast(int value)
    {
        DblNode newTail = new DblNode(value, null, tail);
        tail.next = newTail;
        tail = newTail;
    }

    public void RemoveFirst()
    {
        head.next.prev = null;
        head = head.next;
    }

    public void RemoveLast()
    {
        tail.prev.next = null;
        tail = tail.prev;
    }
}

public class DblNode
{
    internal int data;
    internal DblNode? next;
    internal DblNode? prev;

    public DblNode(int value, DblNode? _next, DblNode? _prev)
    {
        data = value;
        next = _next;
        prev = _prev;
    }
}