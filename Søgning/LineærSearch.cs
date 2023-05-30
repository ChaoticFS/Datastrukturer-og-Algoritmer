namespace search;
public class LineærSearch
{ // Specifikt til numre, kan sagtens laves til andre typer uden større modifikation
    public bool Search(List<int> list, int targetVal)
    {
        foreach (var item in list)
        {
            if (item == targetVal)
            {
                return true;
            }
        }

        return false;
    }
}