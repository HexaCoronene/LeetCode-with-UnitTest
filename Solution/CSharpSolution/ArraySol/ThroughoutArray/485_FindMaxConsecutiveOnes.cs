namespace LeetCode.Solution.ArraySol;

public class FindMaxConsecutiveOnesSolution
{
    public static int FindMaxConsecutiveOnes(int[] nums)
    {
        int ans = 0, count = 0;
        foreach (var num in nums)
        {
            if (num == 1)
            {
                count++;
            }
            else
            {
                ans = Math.Max(count, ans);
                count = 0;
            }
        }
        return Math.Max(count, ans);;
    }
}