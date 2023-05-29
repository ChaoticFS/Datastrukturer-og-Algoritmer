namespace sort;
public class SelectionSort
{
    public List<int> Sort(List<int> input)
    {
        List<int> list = input;

        int n = list.Count;

        // finder index på hvad der er mindst og swapper nummeret med startindexet
        for (int i = 0; i < n; i++)
        {
            int min_index = i;

            for (int j = i + 1; j < n; j++)
            {
                if (list[j] < list[min_index])
                {
                    min_index = j;
                }
            }

            int temp = list[min_index];
            list[min_index] = list[i];
            list[i] = temp;
        }

        return list;
    }
}