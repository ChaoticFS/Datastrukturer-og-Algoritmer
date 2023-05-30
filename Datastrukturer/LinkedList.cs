namespace datastructure;

public class LinkedList
{
    Node? head;

    public LinkedList(int value)
    {
        head = new Node(value);
    }

    public void Add(int value)
    {
        Node newNode = new Node(value, head);
        head = newNode;
    }

    public void RemoveFirst()
    {
        if (head == null)
        {
            throw new IndexOutOfRangeException("No elements in list");
        }

        if (head.next == null)
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
        Node? next = head;

        while (next is not null)
        {
            count++;
            next = next.next;
        }

        return count;
    }

    public bool Contains(int targetVal)
    {
        Node? next = head;

        while (next is not null)
        {
            if (next.data.Equals(targetVal))
            {
                return true;
            }
        }

        return false;
    }

    public int GetLast()
    {
        Node? next = head;

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

public class Node
{
    internal int data;
    internal Node? next;

    public Node(int value)
    {
        data = value;
        next = null;
    }

    public Node(int value, Node _next)
    {
        data = value;
        next = _next;
    }
}