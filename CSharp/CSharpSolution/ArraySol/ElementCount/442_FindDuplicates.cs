namespace LeetCode.Solution.ArraySol.ElementCount;

public class FindDuplicatesSolution
{
    public static IList<int> FindDuplicates(int[] nums)
    {
        List<int> ans = [];
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;

            if (nums[index] > 0)
                nums[index] = -nums[index];
            else
                ans.Add(index + 1);
        }

        return ans;
    }
}