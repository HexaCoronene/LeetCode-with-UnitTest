namespace LeetCode.Solution;

public class TwoSumSolution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> result = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (result.ContainsKey(target - nums[i]))
                return [result[target - nums[i]], i];
            if (!result.TryAdd(nums[i], i))
                result[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}