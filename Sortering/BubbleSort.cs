namespace sort;
public class BubbleSort
{
    public List<int> Sort(List<int> input)
    {
        List<int> list = input;

        // Tidskompleksitet er O(n^2), nested loop yknow
        for (int i=list.Count-1; i>=0; i--)
        {
            for (int j=0; j<=i-1; j++)
            {
                if (list[j] > list[j+1])
                {
                    // relativt simpel, gem gammel værdi af indeks og ryk den en tak
                    int temp = list[j];

                    list[j] = list[j+1];
                    list[j+1] = temp;
                }
            }
        }

        return list;
    }
}