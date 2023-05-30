namespace search;
public class BinærSearch
{ // Fungerer kun på sorteret liste
    public bool Search(List<int> list, int targetVal)
    {
        int L = 0;
        int R = list.Count - 1;

        while (L <= R)
        {
            int M = (L + R) / 2;

            if (list[M] == targetVal)
            {
                return true;
            }
            else if (list[M] < targetVal) 
            {
                L = M + 1;
            }
            else
            {
                R = M - 1;
            }

        }

        return false;
    }
}