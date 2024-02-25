using System.Linq;

public class ArrayFilter
{
    public static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        return originalArray.Except(filterArray).ToArray();
    }
}
