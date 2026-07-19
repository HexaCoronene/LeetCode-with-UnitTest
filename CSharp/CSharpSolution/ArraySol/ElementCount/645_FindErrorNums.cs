namespace LeetCode.Solution.ArraySol.ElementCount;

public class FindErrorNumsSolution
{
    public static int[] FindErrorNums(int[] nums)
    {
        int[] ans = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            // 不在正确的位置上
            while (nums[i] != i + 1)
            {
                // 找到 nums[i] 应该出现的位置：idx = nums[i] - 1
                // 如果该位置上的数是正确的，那么 nums[i] 就是重复的数
                int idx = nums[i] - 1;
                if (nums[idx] == nums[i])
                {
                    ans[0] = nums[idx];
                    break;
                }
                (nums[idx], nums[i]) = (nums[i], nums[idx]);
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
            {
                ans[1] = i + 1;
                break;
            }
        }
        return ans;
    }
}