namespace datastructure;

public interface IMap<K, V>
{
    public V Get(K key);
    public V Put(K key, V value);
    public V Remove(K key);
    public bool IsEmpty();
    public int Size();
}

public class HashMap<K, V> : IMap<K, V> 
{ // Bruger chaining til konflikter
    private HashNode[] buckets;
    private int currentSize;

    private class HashNode
    {
        public K key;
        public V value;
        public HashNode? next;

        public HashNode(K key, V value, HashNode? next)
        {
            this.key = key;
            this.value = value;
            this.next = next;
        }

        public HashNode(K key, V value)
        {
            this.key = key;
            this.value = value;
            this.next = null;
        }
    }
    
    public HashMap(int size)
    {
        buckets = new HashNode[size];
        currentSize = 0;
    }

    private int HashValue(K key)
    {
        int hashVal = key.GetHashCode();

        if (hashVal < 0) 
        {
            hashVal = -hashVal;
        }

        hashVal = hashVal % buckets.Length;
        return hashVal;
    }

    public V Get(K key)
    {
        int hashVal = HashValue(key);

        HashNode bucket = buckets[hashVal];

        if (bucket.value == null)
        {
            return default;
        }

        while (bucket.next != null) 
        {
            if (bucket.key.Equals(key))
                {
                    return bucket.value;
                }
        }

        return default;
    }

    public V Put(K key, V value)
    {
        int hashVal = HashValue(key);

        if (buckets[hashVal].value != null)
        {
            HashNode currentNode = buckets[hashVal];

            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            HashNode newNode = new HashNode(key, value);

            currentNode.next = newNode;
        }

        else
        {
            HashNode newNode = new HashNode(key, value);

            buckets[hashVal] = newNode;
        }

        currentSize++;
        return value;
    }

    public V Remove(K key)
    {
        int hashVal = HashValue(key);
        
        HashNode bucket = buckets[hashVal];

        if (bucket.value == null)
        {
            return default;
        }

        HashNode currentNode = buckets[hashVal];

        if (currentNode.key.Equals(key))
        {
            buckets[hashVal] = currentNode.next;

            currentSize--;
            return default;
        }

        while (currentNode.next != null) 
        {
            HashNode tempNode = currentNode.next;

            if (tempNode.key.Equals(key))
            {
                currentNode.next = tempNode.next;

                currentSize--;
                return default;
            }

            currentNode = tempNode;
        }

        return default;
    }

    public bool IsEmpty()
    {
        foreach (var bucket in buckets)
        {
            if (bucket.value != null)
            {
                return false;
            }
        }

        return true;
    }

    public int Size()
    {
        return currentSize;
    }
}