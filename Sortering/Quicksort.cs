namespace sort;
public class QuickSort
{
    public void Sort(List<int> input, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(input, low, high);

            Sort(input, low, partitionIndex - 1);
            Sort(input, partitionIndex + 1, high);
        }
    }

    int Partition(List<int> input, int low, int high)
    {
        int pivot = input[high];

        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (input[j] < pivot)
            {
                i++;
                Swap(input, i, j);
            }
        }
        Swap(input, i + 1, high);
        return (i + 1);
    }

    void Swap(List<int> input, int x, int y)
    {
        int temp = input[x];
        input[x] = input[y];
        input[y] = temp;
    }
}