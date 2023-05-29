namespace sort;
public class InsertionSort
{
    public List<int> Sort(List<int> input)
    {
        List<int> list = input;

        for (int i = 1; i < list.Count; i++)
        {
            int key = list[i];
            int j = i - 1;

            while (j >= 0 && list[j] > key)
            { // basically swap værdi fra højre mod venstre indtil den ikke længere er lavere end tidligere indeks
                list[j + 1] = list[j];
                j--;
            }
            list[j+1] = key;
        }

        return list;
    }
}