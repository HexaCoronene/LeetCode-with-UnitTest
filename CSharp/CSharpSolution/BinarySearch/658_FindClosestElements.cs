namespace LeetCode.Solution.BinarySearch;

public class FindClosestElementsSolution
{
    public static IList<int> FindClosestElements(int[] arr, int k, int x)
     => arr.OrderBy(num => Math.Abs(num - x)).Take(k).OrderBy(i => i).ToList();
}