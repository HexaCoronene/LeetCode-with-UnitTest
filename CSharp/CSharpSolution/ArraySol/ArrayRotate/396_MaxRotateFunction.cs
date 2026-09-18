namespace LeetCode.Solution.ArraySol.ArrayRotate;

public class MaxRotateFunctionSolution
{
    public static int MaxRotateFunction(int[] nums)
    {
        int sum = nums.Sum();
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
            max += i * nums[i];

        int next = max;
        for (int i = 1; i < nums.Length; i++)
        {
            next = next + sum - nums.Length * nums[nums.Length - i];
            max = Math.Max(max, next);
        }
        return max;
    }
}