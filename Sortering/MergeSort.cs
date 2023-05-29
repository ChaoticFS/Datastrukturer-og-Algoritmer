namespace sort;
public class MergeSort
{ // L = Venstre indeks, R = Højre indeks, M = Midterste indeks
    public List<int> Sort(List<int> input, int L, int R)
    {
        List<int> list = input;

        if (L < R)
        {
            int M = L + (R - L) / 2;

            Sort(list, L, M);
            Sort(list, M + 1, R);

            Merge(list, L, M, R);
        }


        return list;
    }

    public void Merge(List<int> input, int L, int M, int R)
    {
        int leftLength = M - L + 1;
        int rightLength = R - M;

        List<int> leftTemp = new List<int>();
        List<int> rightTemp = new List<int>();

        int i, j;

        for (i = 0; i < leftLength; i++)
        {
            leftTemp.Add(input[L + i]);
        }
        for (j = 0; j < rightLength; j++)
        {
            rightTemp.Add(input[M + 1 + j]);
        }

        i = 0;
        j = 0;
        int k = L;

        while (i < leftLength && j < rightLength) 
        {
            if (leftTemp[i] <= rightTemp[j])
            {
                input[k++] = leftTemp[i++];
            }
            else
            {
                input[k++] = rightTemp[j++];
            }
        }

        while (i < leftLength)
        {
            input[k++] = leftTemp[i++];
        }

        while (j < rightLength)
        {
            input[k++] = rightTemp[j++];
        }
    }
}