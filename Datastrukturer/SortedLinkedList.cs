namespace datastructure;

public class SortedLinkedList
{
    SNode? head;

    public SortedLinkedList(int value)
    {
        head = new SNode(value);
    }

    public SortedLinkedList()
    {
        head = null;
    }

    public void Add(int value)
    {
        SNode newNode = new SNode(value);

        if (head == null || value < head.data) 
        {
            newNode.next = head;
            head = newNode;
        }

        else
        {
            SNode current = head;
            while (current.next != null && current.next.data < value)
            {
                current = current.next;
            }

            newNode.next = current.next;
            current.next = newNode;
        }
    }

    public void RemoveFirst()
    {
        if (head == null)
        {
            throw new IndexOutOfRangeException("No elements in list");
        }

        else if (head.next == null)
        {
            head = null;
        }

        else
        {
            head = head.next;
        }
    }

    public int Count()
    {
        int count = 0;
        SNode? next = head;

        while (next is not null)
        {
            count++;
            next = next.next;
        }

        return count;
    }

    public bool Contains(int targetVal)
    {
        SNode? next = head;

        while (next is not null)
        {
            if (next.data.Equals(targetVal))
            {
                return true;
            }

            next = next.next;
        }

        return false;
    }

    public int GetLast()
    {
        SNode? next = head;

        while (next is not null)
        {
            if (next.next is null)
            {
                return next.data;
            }

            next = next.next;
        }

        return -1;
    }
}

public class SNode
{
    internal int data;
    internal SNode? next;

    public SNode(int value)
    {
        data = value;
        next = null;
    }
}