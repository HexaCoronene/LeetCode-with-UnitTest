namespace LeetCode.Solution.ArraySol.ElementCount;

public class HIndexSolution
{
    public static int HIndex(int[] citations)
    {
        Array.Sort(citations);
        // Array.Reverse(citations);

        // 自顶向下
        for (int i = 0; i < citations.Length; i++)
        {
            int result = citations.Length - i;
            if (result <= citations[i])
                return result;
        }

        return 0;
    }
}